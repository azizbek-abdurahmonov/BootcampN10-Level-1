using N26_HT2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N26_HT2.Models
{
    internal class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public SkillLevel Level { get; set; }

        public Skill(string name, SkillLevel level)
        {
            Name = name;
            Level = level;
        }

    }
}
