using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace client.Models
{
    public class InventoryUnitType
    {
        [JsonPropertyName("type_id")]
        public int Id { get; set; }

        [JsonPropertyName("unit_name")]
        public string? UnitName { get; set; }

        [JsonPropertyName("unit_symbol")]
        public string? UnitSymbol { get; set; }
    }
}
