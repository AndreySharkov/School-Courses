using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterByAge
{
    public class Person
    {
        public string name;
        public int age;

        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(string name)
        {
           this.name = name;
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
