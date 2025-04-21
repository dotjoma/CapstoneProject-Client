using client.Helpers;
using client.Models;
using client.Models.Audit;
using client.Network;
using client.Services;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class SupplierController
    {
        AuditService _auditService = new AuditService();

        public async Task<bool> CreateSupplier(string supplierName, string contactPerson, string phone, string email, string address, bool isActive)
        {
            if (string.IsNullOrWhiteSpace(supplierName))
            {
                MessageBox.Show("Supplier name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.CreateSupplier,
                    Data = new Dictionary<string, string>
                    {
                        { "supplierName", supplierName },
                        { "contactPerson", contactPerson },
                        { "phone", phone },
                        { "email", email },
                        { "address", address },
                        { "isActive", isActive.ToString() }
                    }
                });

                if (response == null)
                {
                    MessageBox.Show("Failed to create supplier. Server not responding.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data?.ContainsKey("success") == true &&
                    response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("CREATE SUPPLIER", $"Supplier '{supplierName}' created successfully");

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Supplier created successfully",
                        OldValue = "No supplier existed",
                        NewValue = $"Name: {supplierName}, Contact: {contactPerson}, Phone: {phone}",
                        EntityType = AuditEntityType.Supplier,
                        EntityId = ""
                    });

                    return true;
                }
                else
                {
                    string errorMessage = response.Data?.ContainsKey("message") == true
                        ? response.Data["message"]
                        : "Unknown error occurred while creating supplier";

                    Logger.Write("CREATE SUPPLIER", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create supplier: {errorMessage}", "Supplier Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Write("CREATE SUPPLIER", $"Exception: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<Supplier>> GetAllInventorySuppliers()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetSupplier
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<Supplier>();
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string suppliersJson = response.Data["suppliers"];
                    List<Supplier>? suppliers = JsonSerializer.Deserialize<List<Supplier>>(
                        suppliersJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentSupplier.SetSuppliers(suppliers ?? new List<Supplier>());

                    return suppliers ?? new List<Supplier>();
                }
                else
                {
                    string errorMessage = "Failed to retrieve suppliers: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Supplier Retrieval Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return new List<Supplier>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<Supplier>();
            }
        }
    }
}
