using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace client.Models
{
    public class InventoryUnitMeasure
    {
        [JsonPropertyName("measure_id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? measureName { get; set; }

        [JsonPropertyName("symbol")]
        public string? measureSymbol { get; set; }
    }
}
