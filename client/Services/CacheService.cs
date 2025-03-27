using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using client.Models;

namespace client.Services
{
    public class CacheService
    {
        private static readonly string CacheFilePath = "cachedata.cache";

        public static CacheData GetCachedData()
        {
            if (!File.Exists(CacheFilePath))
            {
                return new CacheData();
            }

            var json = File.ReadAllText(CacheFilePath);
            return JsonConvert.DeserializeObject<CacheData>(json) ?? new CacheData();
        }

        public static void SaveToCache(CacheData cacheData)
        {
            var json = JsonConvert.SerializeObject(cacheData, Formatting.Indented);
            File.WriteAllText(CacheFilePath, json);
        }
    }
}
