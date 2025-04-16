using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace client.Models
{
    public class InventoryCategory
    {
        [JsonPropertyName("category_id")]
        public int Id { get; set; }

        [JsonPropertyName("category_name")]
        public string? Name { get; set; }
    }
}
