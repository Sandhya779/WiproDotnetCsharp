using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DupCh
    {
        public void Dupcha(string s)
        {
            int[] ch = new int[256];
            List<char> dup= new List<char>();
            foreach (char c in s)
            {
                ch[c]++;
                if (ch[c]==2)
                    dup.Add(c);
            }
            Console.WriteLine("Duplicates: ");
            foreach (char c in dup)
                Console.Write(c+" ");
            Console.WriteLine();
            HashSet<char> printed = new HashSet<char>();
            Console.WriteLine("String after removing duplicates");
            foreach (char c in s)
            {
                if (!printed.Contains(c))
                    Console.Write(c+" ");
                    printed.Add(c);
            }
            Console.WriteLine();
        }
    }
}
