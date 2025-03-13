using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string AccType { get; set; }
        
        public void Branch()
        {
            Console.WriteLine("hi");
        }
        public virtual void AccountTypes()
        {
            Console.Write("hi");
        }
    }
}
