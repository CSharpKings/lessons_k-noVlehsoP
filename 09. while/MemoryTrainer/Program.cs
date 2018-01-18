using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryTrainer {
	class Program {
		static void Main(string[] args) {
			GuessNumber();
		}

		static void GuessNumber() {
			Random rand = new Random();
            int maxik = 100;
			while (true) {
                
                int number = rand.Next(maxik);
             
                
				
                Console.WriteLine("Запомните число: " + number);
				Thread.Sleep(2000);
				Console.Clear();

				Console.WriteLine("Введите запомненное число");
				int guess = int.Parse(Console.ReadLine());
				Console.WriteLine();

				if (guess == number) {
					Console.WriteLine("Вы угадали!");
                    maxik = maxik+200;
				}
				else {
					Console.WriteLine("Вы ошиблись ='(");
                    maxik = maxik-100;
				}
				Thread.Sleep(1000);
				Console.Clear();
			}
		}
	}
}
