using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Filters
{
    public static class CacheExtensions
    {
        public static void Set<T>(this IDistributedCache cache,string key,T value)
        {
            string context= JsonSerializer.Serialize(value);
            cache.SetString(key,context);
        }
        public static T Get<T>(this IDistributedCache cache, string key)
        {
            string cached= cache.GetString(key);
            return string.IsNullOrWhiteSpace(cached) ? default : JsonSerializer.Deserialize<T>(cached);
        }
    }
}
