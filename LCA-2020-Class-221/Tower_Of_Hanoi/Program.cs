using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Of_Hanoi
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{

				Dictionary<string, Stack<int>> towers = new Dictionary<string, Stack<int>>();
				Stack<int> Disks = new Stack<int>();


				Disks.Push(1);
				Disks.Push(2);
				Disks.Push(3);
				Disks.Push(4);

				towers.Add("A:", Disks);
				Disks = new Stack<int>();
				towers.Add("B:", Disks);
				towers.Add("C:", Disks);


				foreach (var tow in towers)
				{

					var item_key = tow.Key;
					string print_tower = item_key;

					foreach (var stack_item in tow.Value)
					{

						print_tower += " " + stack_item.ToString();

					}

					Console.WriteLine(print_tower);

				}

				var moving = Disks;

				//Disks.Push(7);
				var valueInStack = Disks.Pop();
				Console.WriteLine(valueInStack.ToString());

				Disks.Pop();
				Console.ReadLine();

			}
			/*
			Console.WriteLine("Type in A, B, or C to target and move a disc");
			string input = Console.ReadLine().ToUpper();

			if ((input == "A") && (input == "B"))
			{
				Disks.Pop();
			}

			Console.ReadLine(); */
		}
	}
}
