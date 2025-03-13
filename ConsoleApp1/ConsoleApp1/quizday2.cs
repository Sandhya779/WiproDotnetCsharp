using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Quizday2
    {
        public void Def()
        { 
            string[] st = new string[] {"apple1", "banana2", "cherry3"};
            //for (int i = 0; i < 3; i++)
            //{
            //    st[i]=Console.ReadLine();
            //}
            //for (int i = 0;i < 3;i++)
            //{
            //    Console.Write(st[i]);
            //}
            string s = string.Join("", st);
            Console.WriteLine($"Concatenated String:\"{s}\"");
            List<int> ol=new List<int>();
            
            for(int i=0;i<s.Length;i++)
            {
                if (char.IsDigit(s[i]))
                    ol.Add(s[i]-'0');
            }
            
            int maxi = ol[0];
            int mini = ol[0];
            Console.WriteLine("Extracted Numbers: [" + string.Join(",", ol) + "]");
            foreach (var i in ol)
            {
                
                if (i > maxi)
                    maxi =i;
                if (i < mini)
                    mini = i;
            }
            Console.WriteLine("Maximum Number: "+maxi);
            Console.WriteLine("Minimum Number: "+mini);
            Console.WriteLine("Difference: "+(maxi-mini));
        }
        
    }
    //class Program
    //{
    //    public static void Main(String[] args)
    //    {
    //        ConsoleApp1.Quizday2 ob = new ConsoleApp1.Quizday2();
    //        ob.Def();
    //    }
    //}
}
