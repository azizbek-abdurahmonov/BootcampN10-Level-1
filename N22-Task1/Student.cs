using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace N22_Task1
{
    internal class Student<TId, TGrade>
    {
        public TId Id { get; set; }
        public string Name { get; set; }
        public TGrade Grade { get; set; }

        public Student(TId id, string name, TGrade grade)
        {
            this.Id = id;
            this.Name = name;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nGrade: {Grade}";
        }
    }
}
