using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_T1
{
    internal class Person
    {
        private string name;
        private int age;
        private string city;

        public Person() { }
        static Person() 
        {
            Console.WriteLine("Statik Konstruktor chaqirildi!");
        }

        public Person(string name, int age, string city)
        {
            this.name = name;
            this.age = age;
            this.city = city;
        }

        public Person(Person person)
        {
            this.name = person.name;
            this.age = person.age;
            this.city = person.city;
        }

        public override string ToString()
        {
            return $"Name: {name}\nAge: {age}\nCity: {city}";
        }

    }
}
