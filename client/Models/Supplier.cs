using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace client.Models
{
    public class Supplier
    {
        [JsonPropertyName("supplier_id")]
        public int Id { get; set; }

        [JsonPropertyName("supplier_name")]
        public string? SupplierName { get; set; }

        [JsonPropertyName("contact_person")]
        public string? ContactPerson { get; set; }

        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("is_active")]
        public int IsActive {  get; set; }
    }
}
