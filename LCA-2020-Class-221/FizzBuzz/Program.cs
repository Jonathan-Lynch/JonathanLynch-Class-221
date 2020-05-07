using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{

            for (int j = 1; j <= 100; j++)
            {
				if ((j % 3 == 0) && (j % 5 == 0))
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (j % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (j % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(j);
				}
            }
			Console.ReadLine();
		}
	}
}
