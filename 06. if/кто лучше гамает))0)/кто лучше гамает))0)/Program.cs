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
            Console.WriteLine("Кто лучше гамает: ты или кореш?");
            Console.WriteLine("Че по рейтингу у вас?");
            Console.WriteLine("у тя:");
            Console.WriteLine("у кореша:");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine("красава, твой кореш всего лишь жалкий падаван");
            }
            else
            {
                Console.WriteLine("ты падаван");
            }
        }
    }
}
