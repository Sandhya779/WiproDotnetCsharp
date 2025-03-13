using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class remZero
    {
        public class Zero
        {
            public void FindZ()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                int j = 0;
                int k = 0;
                while (j < arr.Length)
                {
                    if (arr[j] == 0)
                        j++;
                    else
                    {
                        arr[k] = arr[j];
                        j++;
                        k++;
                    }
                }

                while (k < arr.Length)
                {
                    arr[k] = 0;
                    k++;
                }
                for (int p = 0; p < n; p++)
                {
                    Console.Write(arr[p] + " ");
                }
                Console.WriteLine();

            }
        }
    }

}
