using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class InventoryExpiryTracker
    {
        public static (List<InventoryBatch> Expired, List<InventoryBatch> ExpiringSoon) CheckExpirations(
            List<InventoryBatch> allBatches, int daysUntilExpiring = 7)
        {
            DateTime now = DateTime.Now;
            DateTime threshold = now.AddDays(daysUntilExpiring);

            var expired = allBatches
                .Where(b => b.ExpirationDate.HasValue && b.ExpirationDate.Value.Date < now.Date)
                .ToList();

            var expiringSoon = allBatches
                .Where(b => b.ExpirationDate.HasValue &&
                            b.ExpirationDate.Value.Date >= now.Date &&
                            b.ExpirationDate.Value.Date <= threshold.Date)
                .ToList();

            return (expired, expiringSoon);
        }
    }
}
