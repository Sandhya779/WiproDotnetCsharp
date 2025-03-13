using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cons10
    {
        public void Consec(int[] arr)
        {
            int cons = 1, glob = 1;
            for (int i = 0; i < (arr.Length)-1; i++)
            {
                if (arr[i] == arr[i + 1])
                    cons++;
                else
                {
                    if(cons>glob)
                        glob = cons;
                    cons = 1;
                }
                    
            }
            if(glob<cons)
                glob = cons;
            Console.WriteLine(glob);
        }
    }
}
