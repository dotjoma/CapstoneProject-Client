using client.Helpers;
using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentInventoryBatch
    {
        private static InventoryBatch? _currentBatch;
        private static List<InventoryBatch> _allBatches = new List<InventoryBatch>();

        public static InventoryBatch? Current => _currentBatch;
        public static List<InventoryBatch> AllBatches => _allBatches;

        public static void SetBatches(List<InventoryBatch>? batches)
        {
            _allBatches = batches ?? new List<InventoryBatch>();
            _currentBatch = null;
        }

        public static void SetCurrentBatch(InventoryBatch? batch)
        {
            _currentBatch = batch;
        }

        public static InventoryBatch? GetBatchById(int batchId)
        {
            return _allBatches.FirstOrDefault(c => c.BatchId == batchId);
        }

        public static List<InventoryBatch> GetBatchesByItemId(int itemId)
        {
            return _allBatches
                .Where(batch => batch.BatchId == itemId)
                .ToList();
        }


        public static void Clear()
        {
            _currentBatch = null;
            _allBatches.Clear();
        }
    }
}
