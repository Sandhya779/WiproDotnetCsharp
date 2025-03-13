//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ConsoleApp1;

//namespace ConsoleApp1
//{
//    internal class day2mrng
//    {
//        public void Multidim()
//        {
//            int[,] arr = new int[2, 3];
//            arr[0, 0] = 1;
//            arr[0, 1] = 2;
//            arr[0, 2] = 3;
//            arr[1, 0] = 4;
//            arr[1, 1] = 5;
//            arr[1, 2] = 6;
//        }
//        public void Jagged()
//        {
//            // declaration
//            //int[][] jag = [new int[3], new int[2], new int[1]]
//            int[][] jag = new int[2][];
    
//            jag[0] = new int[3];
//            jag[1] = new int[2];
//            //jag[2] = new int[1];

//            jag[0][0] = 101;
//            jag[0][1] = 200;
//            jag[0][2] = 300;

//            jag[1][0] = 101;
//            jag[1][1] = 200;
//            //jag[1][2] = 300;

//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < jag[i].Length;j++)
//                {
//                    Console.WriteLine(jag[i][j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//        public class Account
//        {
//            public int AccID { get; set; }
//            public string Name { get; set; }
//            public string Password { get; set; }
//            public string AccType { get; set; }
//            public virtual void AccountTypes()
//            {
//                string[] types = { "current", "savings", "corporate" };
//                foreach (string type in types)
//                {
//                    Console.WriteLine(type);
//                }

//            }
//        }
//        public static void Main(string[] args)
//        {
//            day2mrng obj = new day2mrng();
//            obj.Jagged();
//        }
//    }

    
//}


