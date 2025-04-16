using client.Helpers;
using client.Models.Audit;
using client.Network;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class SupplierController
    {
        //public async Task<bool> CreateSupplier(string supplierName, string contactPerson, string phone, string email, string address, bool isActive)
        //{
        //    if (string.IsNullOrWhiteSpace(supplierName))
        //    {
        //        MessageBox.Show("Measure name cannot be empty.", "Validation Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    try
        //    {
        //        var response = await Client.Instance.SendRequestAsync(new Packet
        //        {
        //            Type = PacketType.CreateUnitMeasure,
        //            Data = new Dictionary<string, string>
        //            {
        //                { "supplierName", supplierName },
        //                { "contactPerson", contactPerson },
        //                { "phone", phone },
        //                { "email", email },
        //                { "address", address },
        //                { "isActive", isActive.ToString() }
        //            }
        //        });

        //        if (response == null)
        //        {
        //            MessageBox.Show("Failed to create unit measure. Server not responding.",
        //                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }

        //        if (response.Data?.ContainsKey("success") == true &&
        //            response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
        //        {
        //            Logger.Write("CREATE UNIT MEASURE", $"Unit measure '{measureName}' created successfully");

        //            await _auditService.Log(new AuditRecord
        //            {
        //                UserId = CurrentUser.Current!.UserId,
        //                Action = AuditActionType.Create,
        //                Description = "Unit measure created successfully",
        //                OldValue = "No unit measure existed",
        //                NewValue = $"Name: {measureName}",
        //                EntityType = AuditEntityType.UnitMeasure,
        //                EntityId = ""
        //            });

        //            return true;
        //        }
        //        else
        //        {
        //            string errorMessage = response.Data?.ContainsKey("message") == true
        //                ? response.Data["message"]
        //                : "Unknown error occurred while creating unit measure";

        //            Logger.Write("CREATE UNIT MEASURE", $"Server error: {errorMessage}");
        //            MessageBox.Show($"Failed to create unit measure: {errorMessage}", "Unit Measure Creation Failed",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Write("CREATE UNIT MEASURE", $"Exception: {ex.Message}");
        //        MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}
    }
}
