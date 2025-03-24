using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using client.Models;
using client.Helpers;
using System.Text.Json;

namespace client.Network
{
    public class Packet
    {
        public PacketType Type { get; set; }
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;

        public byte[] Serialize()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(this);
                return Encoding.UTF8.GetBytes(jsonString);
            }
            catch (Exception ex)
            {
                Logger.Write("PACKET", $"Error serializing packet: {ex.Message}");
                throw;
            }
        }

        public static Packet? Deserialize(byte[] data)
        {
            try
            {
                string jsonString = Encoding.UTF8.GetString(data);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<Packet>(jsonString, options);
            }
            catch (Exception ex)
            {
                Logger.Write("PACKET", $"Error deserializing packet: {ex.Message}");
                return null;
            }
        }

        public bool IsValid()
        {
            return Data != null &&
                   Enum.IsDefined(typeof(PacketType), Type);
        }
    }
}
