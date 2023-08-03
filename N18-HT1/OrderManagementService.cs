using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_HT1
{
    internal class OrderManagementService
    {
        public List<int> Orders = new List<int>();
        public OrderCacheService Cache = OrderCacheService.GetInstance();

        public int Max()
        {
            var key = CacheKeyConstants.Max(Orders);
            var max = Cache.Get(key);
            if (max != default)
            {
                return max;
            }
            else
            {
                var maxB = 0;
                foreach (var item in Orders)
                {
                    if (item > maxB)
                        maxB = item;
                }
                Cache.Set(key, maxB);
                return maxB;
            }
        }
        public int Min()
        {
            var key = CacheKeyConstants.Min(Orders);
            var min = Cache.Get(key);
            if (min != default)
            {
                return min;
            }

            min = Orders[0];
            foreach (var item in Orders)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            Cache.Set(key, min);
            return min;

        }
        public int Sum()
        {
            var key = CacheKeyConstants.Sum(Orders);
            var sum = Cache.Get(key);
            if (sum != default)
            {
                return sum;
            }

            sum = 0;
            foreach (var item in Orders)
            {
                sum += item;
            }
            Cache.Set(key, sum);
            return sum; 
        }

        public void Add(int amount)
        {
            Orders.Add(amount);

        }
    }
}
