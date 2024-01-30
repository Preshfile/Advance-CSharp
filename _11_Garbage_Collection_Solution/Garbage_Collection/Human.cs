using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection
{
    internal class Human
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Human()
        {
            Name = "John";
            Age = 20;    
        }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} started teaching at the age of: {Age}");
        }

        public void GetOlder()
        {
            Console.WriteLine($"{Name} is older at age: {Age}");
        }
    }
}
