using client.Helpers;
using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentInventoryItem
    {
        private static InventoryItem? _currentItem;
        private static List<InventoryItem> _allItems = new List<InventoryItem>();

        public static InventoryItem? Current => _currentItem;
        public static List<InventoryItem> AllItems => _allItems;

        public static void SetItems(List<InventoryItem>? items)
        {
            _allItems = items ?? new List<InventoryItem>();
            _currentItem = null;
        }

        public static void SetCurrentItem(InventoryItem? item)
        {
            _currentItem = item;
        }

        public static InventoryItem? GetItemById(int itemId)
        {
            return _allItems.FirstOrDefault(c => c.ItemId == itemId);
        }

        public static void Clear()
        {
            _currentItem = null;
            _allItems.Clear();
        }
    }
}
