using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT2.Models
{
    internal class ClonableList<T> : List<T>, ICloneable where T : ICloneable
    {
        public object Clone()
        {
            ClonableList<T> clone = new ClonableList<T>();
            foreach (var item in this)
            {
                clone.Add((T)item.Clone());
            }
            
            return clone;
        }
    }
}