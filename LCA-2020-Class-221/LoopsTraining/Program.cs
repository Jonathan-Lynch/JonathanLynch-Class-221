using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsTraining
{
	class Program
	{
		static void Main(string[] args)
		{

			forLoops();

		}

		static void forLoops()
		{
			for (int i = 0; i < 10; i = i + 1)
			{
				Console.WriteLine("i is =" + " " + i);
				//Console.ReadLine();
			}
			//Console.ReadLine();

			for (int j = 2; j < 8; j = j + 1)
			{
				Console.WriteLine("j is =" + " " + j);
			}
			//Console.ReadLine();

			for (int m = 0; m > -10; m = m - 1)
			{
				Console.WriteLine("m is =" + " " + m);
			}
			Console.ReadLine();

			for(int number = 1; number <= 20; number = number + 1)
			{
				//Console.WriteLine("number is =" + " " + number);
				if (number % 2 == 0)  //(number % 2 == 1)
				{
					Console.WriteLine("Even number is =" + " " + number);
				}
			}

			for (int number = 2; number <= 20; number = number + 2)
			{
					Console.WriteLine("Even number is =" + " " + number);
			}
			Console.ReadLine();

		}

	}
}
