using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StrRev
    {
        public void strReverse(string str)
        {
            //char[] chars = new char[str.Length];
            //int j = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                //chars[j] = str[i];
                //j++;
                Console.Write(str[i]);
            }
            //string x=new string(chars);
            //Console.WriteLine(x);
            //foreach (char c in chars)
            //{
            //    Console.Write(c);
            //}
            Console.WriteLine();
        }
    }
    

}
