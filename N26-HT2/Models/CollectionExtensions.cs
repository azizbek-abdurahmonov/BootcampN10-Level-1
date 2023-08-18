using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N26_HT2.Models
{
    internal static class CollectionExtensions
    {
        public static void Update(this ICollection<Skill> first,  ICollection<Skill> second)
        {
            var added = second.Except(first).ToList();
            var removed = first.Except(second).ToList();
            var updated = first.Intersect(second).ToList();

            foreach(var item in added )
            {
                first.Add(item);
            }
            foreach( var item in removed )
            {
                first.Remove(item);
            }
            foreach(var item in updated )
            {
                var updatedSkill = second.First(x => x.Id == item.Id);
                item.Name = updatedSkill.Name;
                item.Level = updatedSkill.Level;

            }
        }
    }
}
