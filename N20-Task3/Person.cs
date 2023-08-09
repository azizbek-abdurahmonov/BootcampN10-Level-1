using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_Task3
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        public Person(string name, int age , bool ismarried = false) => (Name, Age, IsMarried) = (name, age, ismarried);

        public void DisplayInfo()
        {
            Console.WriteLine($"Ism: {Name}\nYosh: {Age}\nMarried? : {IsMarried}");
        }
    }
}
