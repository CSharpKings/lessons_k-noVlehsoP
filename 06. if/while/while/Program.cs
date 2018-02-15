using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = 0;
            while (true)
            {
                Thread.Sleep(1000);
                sec = sec + 1;
                Console.WriteLine(sec);
            }

        }
    }
}
