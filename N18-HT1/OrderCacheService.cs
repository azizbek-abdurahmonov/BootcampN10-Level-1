using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_HT1
{
    internal class OrderCacheService
    {
        //singleton
        private static OrderCacheService _instance;
        private OrderCacheService() { }
        public static OrderCacheService GetInstance()
        {
            if (_instance == null)
                _instance = new OrderCacheService();
            return _instance;
        }
        //

        public Dictionary<string, int> Cashe = new Dictionary<string, int>();

        public int Get(string key)
        {
            if (Cashe.ContainsKey(key))
                return Cashe[key];
            return default;
        }

        public void Set(string key, int value)
        {
            var isFind = false;
            foreach (var item in Cashe)
            {
                if (item.Key == key)
                {
                    isFind = true;
                    break;
                }
            }
            if (!isFind)
            {
                Cashe.Add(key, value);
            }
        }
    }
}
