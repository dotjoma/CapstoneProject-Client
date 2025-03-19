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

namespace client.Controllers
{
    public class TransactionController
    {
        public async Task<TransactionNumbers?> GenerateTransactionNumbers()
        {
            try
            {
                var generateNumbersPacket = new Packet
                {
                    Type = PacketType.GenerateTransactionNumbers,
                    Data = new Dictionary<string, string>()
                };

                LoggerHelper.Write("DEBUG", $"Sending request packet: Type={generateNumbersPacket.Type}");

                var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(generateNumbersPacket));
                LoggerHelper.Write("DEBUG", $"Raw response received: {JsonConvert.SerializeObject(response)}");

                if (response == null)
                {
                    LoggerHelper.Write("ERROR", "Server response is null. Retrying...");
                    return null;
                }

                LoggerHelper.Write("DEBUG", $"Response received: Type={response.Type}, Success={response.Success}");

                if (response.Success && response.Data != null)
                {
                    if (response.Data.TryGetValue("transNumber", out string? transNumber) &&
                        response.Data.TryGetValue("orderNumber", out string? orderNumber) &&
                        !string.IsNullOrEmpty(transNumber) &&
                        !string.IsNullOrEmpty(orderNumber))
                    {
                        LoggerHelper.Write("SUCCESS", $"Transaction: {transNumber}, Order: {orderNumber} received.");
                        
                        var transaction = new TransactionNumbers(transNumber, orderNumber);
                        CurrentTransaction.SetCurrentTransaction(transaction);

                        return new TransactionNumbers
                        (
                            transNumber,
                            orderNumber
                        );
                    }
                }

                LoggerHelper.Write("ERROR", "Invalid data received. Falling back...");

                string today = DateTime.Now.ToString("yyyyMMdd");
                var nextTransId = await GetNextTransactionId();
                var nextOrderNumber = await GetNextOrderNumber();

                if (nextTransId != -1 && nextOrderNumber != -1)
                {
                    string fallbackTransNumber = $"{today}{nextTransId:D4}";
                    string fallbackOrderNumber = $"{nextOrderNumber:D3}";

                    LoggerHelper.Write("SUCCESS", $"Fallback successful - TransID: {nextTransId}, TransNumber: {fallbackTransNumber}, Order: {fallbackOrderNumber}");
                    return new TransactionNumbers
                        (
                            fallbackTransNumber,
                            fallbackOrderNumber
                        );
                }

                LoggerHelper.Write("ERROR", "Both primary and fallback methods failed");
                return null;
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("ERROR", $"Unexpected error in GenerateTransactionNumbers: {ex.Message}");
                LoggerHelper.Write("DEBUG", $"Stack trace: {ex.StackTrace}");
                return null;
            }
        }


        public async Task<bool> SaveTransaction(string transNumber, string orderNumber)
        {
            var packet = new Packet
            {
                Type = PacketType.SaveTransaction,
                Data = new Dictionary<string, string>
                {
                    { "transNumber", transNumber },
                    { "orderNumber", orderNumber }
                }
            };

            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(packet));

            if (response?.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    LoggerHelper.Write("SAVE TRANSACTION",
                        $"Transaction saved successfully: {transNumber}, {orderNumber}");
                    return true;
                }
                else
                {
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while saving transaction";

                    LoggerHelper.Write("SAVE TRANSACTION", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to save transaction: {errorMessage}",
                        "Transaction Save Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public async Task<bool> RemoveTransaction(string transNumber)
        {
            var removePacket = new Packet
            {
                Type = PacketType.RemoveTransaction,
                Data = new Dictionary<string, string>
                {
                    { "transNumber", transNumber }
                }
            };

            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(removePacket));

            if (response != null && response.Success)
            {
                LoggerHelper.Write("TRANSACTION", $"Successfully removed transaction {transNumber}");
                return true;
            }

            LoggerHelper.Write("TRANSACTION", $"Failed to remove transaction {transNumber}: {response?.Message}");
            return false;
        }

        public async Task<int> GetNextTransactionId()
        {
            var packet = new Packet
            {
                Type = PacketType.GetNextTransactionId,
                Data = new Dictionary<string, string>()
            };

            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(packet));

            if (response?.Data != null && response.Data.ContainsKey("nextId"))
            {
                if (int.TryParse(response.Data["nextId"], out int nextId))
                {
                    LoggerHelper.Write("GET NEXT TRANSACTION ID", $"Next transaction ID: {nextId}");
                    return nextId;
                }
            }

            LoggerHelper.Write("GET NEXT TRANSACTION ID", "Failed to get next transaction ID");
            MessageBox.Show("Failed to get next transaction ID", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }

        public async Task<int> GetNextOrderNumber()
        {
            var packet = new Packet
            {
                Type = PacketType.GetNextOrderNumber,
                Data = new Dictionary<string, string>
                {
                    { "date", DateTime.Now.ToString("yyyy-MM-dd") }
                }
            };

            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(packet));

            if (response?.Data != null && response.Data.ContainsKey("nextOrderNumber"))
            {
                if (int.TryParse(response.Data["nextOrderNumber"], out int nextOrderNumber))
                {
                    LoggerHelper.Write("GET NEXT ORDER NUMBER", $"Next order number: {nextOrderNumber}");
                    return nextOrderNumber;
                }
            }

            LoggerHelper.Write("GET NEXT ORDER NUMBER", "Failed to get next order number");
            MessageBox.Show("Failed to get next order number", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }
}
