using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_HT1
{
    public static class CacheKeyConstants
    {
        public static string Sum(List<int> nums)
        {
            var code = default(int);
            foreach (var item in nums)
            {
                code += item.GetHashCode();
            }
            return $"{code}-sum";
        }

        public static string Max(List<int> nums)
        {
            var code = default(int);
            foreach (var item in nums)
            {
                code += item.GetHashCode();
            }
            return $"{code}-max";
        }

        public static string Min(List<int> nums)
        {
            var code = default(int);
            foreach (var item in nums)
            {
                code += item.GetHashCode();
            }
            return $"{code}-min";
        }

    }
}
