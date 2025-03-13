using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Oops
    {
        public string Name { get; set; }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
     class Dog : Oops
    {
        public override void Eat()
        {

            Console.WriteLine($"the {Name} is eating");
        }
    }
     
}
