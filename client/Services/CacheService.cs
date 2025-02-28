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

        // Method to get cached data
        public static CacheData GetCachedData()
        {
            if (!File.Exists(CacheFilePath))
            {
                return new CacheData(); // Return an empty cache if the file doesn't exist
            }

            var json = File.ReadAllText(CacheFilePath);
            return JsonConvert.DeserializeObject<CacheData>(json) ?? new CacheData();
        }

        // Method to save data to cache
        public static void SaveToCache(CacheData cacheData)
        {
            var json = JsonConvert.SerializeObject(cacheData, Formatting.Indented);
            File.WriteAllText(CacheFilePath, json);
        }
    }
}
