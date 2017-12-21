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
            Console.WriteLine("Думаешь, нападать ли на дракона?");
            Console.WriteLine("Сомневаешься?");
            Console.WriteLine("Тогда тебе к нам))0)");
            Console.WriteLine("Спроси у дракона, сколько ему лет");
            Console.WriteLine("Спроси, сколько у него осталось энергии))0)))0)0)");      
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            
            if (first<150)
            {
                Console.WriteLine("по возрасту все ог");
            }
            else
            {
                Console.WriteLine("тiкаi з городу ");
            }
            if (second < 50)
            {
                Console.WriteLine("по энергии тоже ог");
            }
            else
            {
                Console.WriteLine("тiкаi з городу ");
            }
        }
    }
}
