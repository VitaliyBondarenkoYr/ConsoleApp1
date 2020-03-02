using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5;
            Console.WriteLine("Hello");

            a = int.Parse(Console.ReadLine());


            Console.WriteLine($"A is ={a}, b = {b}");
            Console.ReadKey();
        }
    }
}
