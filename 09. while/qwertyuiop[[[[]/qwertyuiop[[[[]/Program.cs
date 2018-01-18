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
            int sum = 0;
            while (true)
            {
                Console.WriteLine("vvedite chislo");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(sum);
                sum = sum + number;
               
            }

        }
    }
}
