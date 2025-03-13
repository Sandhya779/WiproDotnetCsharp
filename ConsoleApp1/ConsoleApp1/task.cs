//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Task
//    {
//        public class Oddeven
//        {
//            public void InputNum()
//            {
//                Console.Write("Input the number of elements to store in the array:");
//                int n = Convert.ToInt32(Console.ReadLine());
//                int[] num = new int[n];
//                Console.WriteLine("Input " + n + " elements in the array");
//                for (int i = 0; i < n; i++)
//                {
//                    Console.WriteLine("element - " + i + " :");
//                    num[i] = Convert.ToInt32(Console.ReadLine());
//                }
//                int[][] jagged = new int[2][];

//                int oddcount = 0;
//                int evencount = 0;
//                for (int i = 0; i < n; i++)
//                {
//                    if (num[i] % 2 == 0)
//                        evencount++;
//                    else
//                        oddcount++;
//                }
//                jagged[0] = new int[evencount];
//                jagged[1] = new int[oddcount];
//                int evenIndex = 0;
//                int oddIndex = 0;
//                for (int i = 0; i < n; i++)
//                {
//                    if (num[i] % 2 == 0 && evenIndex < evencount)
//                        jagged[0][evenIndex++] = num[i];
//                    else if (num[i] % 2 != 0 && oddIndex < oddcount)
//                        jagged[1][oddIndex++] = num[i];
//                }
//                Array.Sort(jagged[0]);
//                Array.Sort(jagged[1]);
//                Console.WriteLine("The even elements are:");
//                foreach (int i in jagged[0])
//                {
//                    Console.Write(i + " ");
//                }
//                Console.WriteLine();
//                Console.WriteLine("The odd elements are:");
//                foreach (int i in jagged[1])
//                {
//                    Console.Write(i + " ");
//                }
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Task.Oddeven ob = new Task.Oddeven();
//            ob.InputNum();
//        }
//    }
//}
