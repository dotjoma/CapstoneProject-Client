using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace client.Models
{
    public class InventorySubCategory
    {
        [JsonPropertyName("subcategory_id")]
        public int scId { get; set; }

        [JsonPropertyName("category_id")]
        public int catId { get; set; }

        [JsonPropertyName("subcategory_name")]
        public string? scName { get; set; }
    }
}
