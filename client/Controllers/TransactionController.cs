using client.Helpers;
using client.Network;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using client.Models;
using client.Services;
using System.Diagnostics;
using System.Net.Sockets;
using System.Xml.Linq;

namespace client.Controllers
{
    public class TransactionController
    {
        public async Task<TransactionNumbers?> GenerateTransactionNumbers()
        {
            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.GenerateTransactionNumbers,
                    Data = new Dictionary<string, string>()
                });

                Logger.Write("DEBUG", $"Raw response received: {JsonConvert.SerializeObject(response)}");

                if (response == null)
                {
                    Logger.Write("ERROR", "Server response is null. Retrying...");
                    return null;
                }

                Logger.Write("DEBUG", $"Response received: Type={response.Type}, Success={response.Success}");

                if (response.Success && response.Data != null)
                {
                    if (response.Data.TryGetValue("transID", out string? transId) &&
                        response.Data.TryGetValue("transNumber", out string? transNumber) &&
                        response.Data.TryGetValue("orderNumber", out string? orderNumber) &&
                        !string.IsNullOrEmpty(transId) &&
                        !string.IsNullOrEmpty(transNumber) &&
                        !string.IsNullOrEmpty(orderNumber))
                    {
                        Logger.Write("SUCCESS", $"Transaction: {transNumber}, Order: {orderNumber} received.");
                        
                        var transaction = new TransactionNumbers(int.Parse(transId), transNumber, orderNumber);
                        CurrentTransaction.SetCurrentTransaction(transaction);

                        return new TransactionNumbers
                        (
                            int.Parse(transId),
                            transNumber,
                            orderNumber
                        );
                    }
                }

                Logger.Write("ERROR", "Invalid data received. Falling back...");

                string today = DateTime.Now.ToString("yyyyMMdd");
                var nextTransId = await GetNextTransactionId();
                var nextOrderNumber = await GetNextOrderNumber();

                if (nextTransId != -1 && nextOrderNumber != -1)
                {
                    string fallbackTransNumber = $"{today}{nextTransId:D4}";
                    string fallbackOrderNumber = $"{nextOrderNumber:D3}";

                    Logger.Write("SUCCESS", $"Fallback successful - TransID: {nextTransId}, TransNumber: {fallbackTransNumber}, Order: {fallbackOrderNumber}");
                    return new TransactionNumbers
                    (
                        nextTransId,
                        fallbackTransNumber,
                        fallbackOrderNumber
                    );
                }

                Logger.Write("ERROR", "Both primary and fallback methods failed");
                return null;
            }
            catch (Exception ex)
            {
                Logger.Write("ERROR", $"Unexpected error in GenerateTransactionNumbers: {ex.Message}");
                Logger.Write("DEBUG", $"Stack trace: {ex.StackTrace}");
                return null;
            }
        }

        public async Task<bool> ProcessTransaction(TransactionProcessing trans, List<OrderProcessing> order, PaymentProcessing payment)
        {
            try
            {
                if (!ValidateTransaction(trans, out string transError))
                {
                    Logger.Write("VALIDATION", transError);
                    return false;
                }

                if (!ValidateOrders(order, out string orderError))
                {
                    Logger.Write("VALIDATION", orderError);
                    return false;
                }

                if (!ValidatePayment(payment, trans.totalAmount, out string paymentError))
                {
                    Logger.Write("VALIDATION", paymentError);
                    return false;
                }

                //if (!ValidateBusinessRules(trans, order, payment, out string businessError))
                //{
                //    Logger.Write("VALIDATION", businessError);
                //    return false;
                //}

                var transactionData = new Dictionary<string, string>
                {
                    { "transId", trans.TransId.ToString() },
                    { "totalAmount", trans.totalAmount.ToString() },
                    { "status", trans.status! },
                    { "paymentMethod", trans.paymentMethod! }
                };

                var orderProcessingData = JsonConvert.SerializeObject(order);

                var paymentData = new Dictionary<string, string>()
                {
                    { "transId", payment.transId.ToString() },
                    { "amountPaid", payment.amountPaid.ToString() },
                    { "paymentMethod", payment.paymentMethod! },
                    { "referenceNo", payment.referenceNumber ?? string.Empty },
                    { "changeAmount", payment.changeAmount.ToString() }
                };

                Logger.Write("TRANSACTION", $"Sending transaction {trans.TransNo} to the server...");

                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.ProcessTransaction,
                    Data = new Dictionary<string, string>
                    {
                        { "transaction", JsonConvert.SerializeObject(transactionData) },
                        { "order", orderProcessingData },
                        { "payment", JsonConvert.SerializeObject(paymentData) }
                    }
                });

                if (response?.Success == true)
                {
                    Logger.Write("SUCCESS", $"Transaction {trans.TransNo} processed successfully.");
                    return true;
                }

                Logger.Write("ERROR", $"Failed to process transaction {trans.TransNo}: {response?.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Logger.Write("ERROR", $"Error processing transaction: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> SaveTransaction(string transNumber, string orderNumber)
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.SaveTransaction,
                Data = new Dictionary<string, string>
                {
                    { "transNumber", transNumber },
                    { "orderNumber", orderNumber }
                }
            });

            if (response?.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("SAVE TRANSACTION",
                        $"Transaction saved successfully: {transNumber}, {orderNumber}");
                    return true;
                }
                else
                {
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while saving transaction";

                    Logger.Write("SAVE TRANSACTION", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to save transaction: {errorMessage}",
                        "Transaction Save Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public async Task<bool> RemoveTransaction(string transNumber)
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.RemoveTransaction,
                Data = new Dictionary<string, string>
                {
                    { "transNumber", transNumber }
                }
            });

            if (response != null && response.Success)
            {
                Logger.Write("TRANSACTION", $"Successfully removed transaction {transNumber}");
                return true;
            }

            Logger.Write("TRANSACTION", $"Failed to remove transaction {transNumber}: {response?.Message}");
            return false;
        }

        public async Task<int> GetNextTransactionId()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetNextTransactionId,
                Data = new Dictionary<string, string>()
            });

            if (response?.Data != null && response.Data.ContainsKey("nextId"))
            {
                if (int.TryParse(response.Data["nextId"], out int nextId))
                {
                    Logger.Write("GET NEXT TRANSACTION ID", $"Next transaction ID: {nextId}");
                    return nextId;
                }
            }

            Logger.Write("GET NEXT TRANSACTION ID", "Failed to get next transaction ID");
            MessageBox.Show("Failed to get next transaction ID", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }

        public async Task<int> GetNextOrderNumber()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetNextOrderNumber,
                Data = new Dictionary<string, string>
                {
                    { "date", DateTime.Now.ToString("yyyy-MM-dd") }
                }
            });

            if (response?.Data != null && response.Data.ContainsKey("nextOrderNumber"))
            {
                if (int.TryParse(response.Data["nextOrderNumber"], out int nextOrderNumber))
                {
                    Logger.Write("GET NEXT ORDER NUMBER", $"Next order number: {nextOrderNumber}");
                    return nextOrderNumber;
                }
            }

            Logger.Write("GET NEXT ORDER NUMBER", "Failed to get next order number");
            MessageBox.Show("Failed to get next order number", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }

        private bool ValidateTransaction(TransactionProcessing trans, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (trans == null)
            {
                errorMessage = "Transaction data cannot be null";
                return false;
            }

            if (trans.TransId <= 0)
            {
                errorMessage = "Invalid Transaction ID";
                return false;
            }

            if (string.IsNullOrEmpty(trans.paymentMethod))
            {
                errorMessage = "Payment method must be specified";
                return false;
            }

            return true;
        }

        private bool ValidateOrders(List<OrderProcessing> orders, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (orders == null || !orders.Any())
            {
                errorMessage = "Order cannot be empty";
                return false;
            }

            foreach (var item in orders)
            {
                if (item.ProductId <= 0)
                {
                    errorMessage = $"Invalid Product ID in order: {item.ProductId}";
                    return false;
                }

                if (item.Quantity <= 0)
                {
                    errorMessage = $"Invalid Quantity for product {item.ProductId}";
                    return false;
                }

                if (item.Price < 0)
                {
                    errorMessage = $"Invalid Price for product {item.ProductId}";
                    return false;
                }
            }

            return true;
        }

        private bool ValidatePayment(PaymentProcessing payment, decimal transactionTotal, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (payment == null)
            {
                errorMessage = "Payment data cannot be null";
                return false;
            }

            if (payment.amountPaid <= 0)
            {
                errorMessage = "Amount paid must be positive";
                return false;
            }

            if (payment.amountPaid < transactionTotal && payment.paymentMethod != "Credit")
            {
                errorMessage = "Insufficient payment amount";
                return false;
            }

            return true;
        }


        // FIX THE BUG HERE!!!
        private bool ValidateBusinessRules(TransactionProcessing trans, List<OrderProcessing> orders, PaymentProcessing payment, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (orders.Sum(i => i.TotalPrice) != trans.totalAmount)
            {
                errorMessage = "Order total doesn't match transaction amount";
                return false;
            }

            if (payment.transId != trans.TransId)
            {
                errorMessage = "Payment transaction ID mismatch";
                return false;
            }

            return true;
        }
    }
}
