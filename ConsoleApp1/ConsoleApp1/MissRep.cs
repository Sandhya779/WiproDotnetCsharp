using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MissRep
    {
        public void missRepeat(int[] arr)
        {
            int n=arr.Length;
            int miss=0, repeat=0;
            bool[] seen = new bool[n+1];
            
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (seen[arr[i]])
                {
                    repeat=arr[i];
                }
                else
                    seen[arr[i]] = true;
                
            }
            for (int i=1;i<=arr.Length;i++)
            {
                if (!seen[i])
                    miss=i;
            }

            Console.WriteLine("Missing: "+miss);
            
            Console.Write("Repeating: "+repeat);
            
            Console.WriteLine();
        }   

    }
}
