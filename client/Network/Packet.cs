using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using client.Models;

namespace client.Network
{
    public class Packet
    {
        public PacketType Type { get; set; }
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
