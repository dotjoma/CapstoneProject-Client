using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Helpers
{
    public static class RecipeBuilder
    {
        public static Dictionary<int, (InventoryItem item, decimal quantity, string? measureSymbol)> SelectedIngredients
        = new Dictionary<int, (InventoryItem item, decimal quantity, string? measureSymbol)>();
    }
}
