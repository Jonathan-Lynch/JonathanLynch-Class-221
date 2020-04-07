using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTraining
{
	class Program
	{
		static void Main(string[] args)
		{

			toThePower();

		}

		static void toThePower()
		{
			Console.WriteLine("Write Number one: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			double num1Conv = Math.Pow(num1, 2);
			int firstNum = Convert.ToInt32(num1Conv);
			Console.WriteLine("Write Number two: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			double num2Conv = Math.Pow(num2, 2);
			int secondNum = Convert.ToInt32(num2Conv);
			int bothNum = firstNum + secondNum;
			int total = bothNum;
			Console.WriteLine(total);
			Console.ReadLine();
		}
	}
}
