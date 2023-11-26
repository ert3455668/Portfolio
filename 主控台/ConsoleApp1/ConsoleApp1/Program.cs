using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //先接收數字來源 
            //將接收到的str轉成int
            //判斷int是奇數或偶數亦或者兩者都不是
            //判斷完再出結果 
            
            Console.WriteLine("請輸入數字");
            var input =  Console.ReadLine();
            int num = int.Parse(input);
            
            if(num == 0)
            {
                Console.WriteLine("您輸入數字不得為0");
            }
            else if(num>1)
            {
                int result = num / 2;
                
            }
            

            Console.WriteLine($"您輸入的數字為{num},");
            
            

        }
    }
}
