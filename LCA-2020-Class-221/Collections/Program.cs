using System;
using System.Collections.Generic; //important
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
	class Program
	{
		static void Main(string[] args)
		{

			stackPractice();

		}

		static void stackPractice()
		{
			Stack<string> colors = new Stack<string>();
			colors.Push("Red");
			colors.Push("Blue");
			colors.Push("Yellow");

			foreach(String color in colors)
			{
				Console.WriteLine(color);
				//Console.ReadLine();
			}
			Console.ReadLine();

			String Remove = colors.Pop();
			Console.WriteLine("Just Removed {0}", Remove);
			Console.WriteLine("My stack now has {0} elements", colors.Count());
			Console.ReadLine();
			// Peek
		}

	}
}
