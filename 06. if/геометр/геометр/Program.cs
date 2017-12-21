using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Че по сторонам");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            if (third < first+ second)
            {
                Console.WriteLine("этот треугольник такой же настоящий, как твой жир");
            }
             else
            {
                Console.WriteLine("шо це тэке");
            }
        }
    }
}
