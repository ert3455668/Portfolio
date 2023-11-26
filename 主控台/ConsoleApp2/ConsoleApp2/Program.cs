using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int result = 0;
            //int i = 12;
            //do
            //{

            //    result = result+ i;
            //    Console.WriteLine(result);
            //    i = i + 1;
            //    Console.WriteLine($"我是I{i}");   

            //}
            //while (i < 11);
            //Console.WriteLine($"加總結果{result}");
            //Console.ReadLine(); 
            //int[]array =  new int[] { 1, 2,3 };
            //foreach(int i in array)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();

            //    Console.WriteLine("請輸入第一個數字1-100");
            //    ReadDisplay();
            //    Console.WriteLine("請輸入第二個數字1-100");
            //    ReadDisplay();

            //    Console.ReadLine();
            //}
            //private static void ReadDisplay()
            //{
            //    string s = Console.ReadLine();
            //    Console.WriteLine(s);
            //}


            //private static void SayHello()
            //{
            //    Console.WriteLine("Hello C#");
            //    Console.ReadLine();
            //}
            int condition = 15;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
                for (int j = 11; j < 20; j++)
                {
                    if (j == condition)
                    {
                        //continue;
                        break;
                    }
                   
                    Console.WriteLine($"J={j}");
                }
            }
            Console.WriteLine("----------------------------------------------------------------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
                for (int j = 11; j < 20; j++)
                {
                    if (j == condition)
                    {
                        continue;
                        //break;
                    }
                   

                    Console.WriteLine($"J={j}");
                }
            }
            Console.ReadLine();
        }
        
    }
}
