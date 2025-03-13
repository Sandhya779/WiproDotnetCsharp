using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Secondmax
    {
        public void Secondma(int[] arr)
        {
            int n=arr.Length;
            int first = arr[0], second = -1;
            if (n < 2) 
                second=-1;
            
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }
            Console.WriteLine(second);
            //return second;
            

        }
    }
}
