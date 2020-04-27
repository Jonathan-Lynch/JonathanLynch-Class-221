using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Of_Hanoi
{
	class Program
	{
		const string winning_combo = "1234";
		static void Main(string[] args)
		{

			//while (true)
			//{

			Dictionary<string, Stack<int>> towers = new Dictionary<string, Stack<int>>();
			Stack<int> Disks = new Stack<int>();


			Disks.Push(4);
			Disks.Push(3);
			Disks.Push(2);
			Disks.Push(1);

			towers.Add("A", Disks);
			Disks = new Stack<int>();
			towers.Add("B", new Stack<int>());
			towers.Add("C", new Stack<int>());

			do
			{

				var firstTower = towers["A"];
				var secondTower = towers["B"];
				var thirdTower = towers["C"];

				//int poppedItem = firstTower.Pop();
				//secondTower.Push(poppedItem);

				Console.Clear();
				foreach (var tow in towers)
				{
					var item_key = tow.Key;
					string print_tower = item_key;
					string print_number = "";

					foreach (var stack_item in tow.Value)
					{
						print_number += " " + stack_item.ToString();
					}
					print_number = Reverse(print_number);

					Console.WriteLine(print_tower + ":" + print_number);
				}

				bool invalid = true;

				do
				{

					Console.WriteLine("Type in A, B, or C to target and move a disc");
					var input = Console.ReadLine().ToUpper().ToUpper();
					

					Console.WriteLine("Type in where you want it to go");
					var inputTo = Console.ReadLine().ToUpper();

					int topToValue = 10;
					int topFromValue = 10;

					if (towers[inputTo].Count > 0)
					{
						topToValue = towers[inputTo].Pop();
						towers[inputTo].Push(topToValue);
					}

					if (towers[input].Count > 0)
					{
						topFromValue = towers[input].Pop();
						towers[input].Push(topFromValue);
					}
					Console.WriteLine("TOP TO: " + topToValue.ToString());
					Console.WriteLine("TOP FROM: " + topFromValue.ToString());

					if (topFromValue < topToValue)
						towers[inputTo].Push(towers[input].Pop());
					else
						Console.WriteLine("Can't move there.");

					Console.ReadLine();


				} while (!invalid);


			} while (true);


			//Disks.Push(7);
			//var valueInStack = Disks.Pop();
			//Console.WriteLine(valueInStack.ToString());
			//Disks.Pop();
			//}


			/*
			Console.WriteLine("Type in A, B, or C to target and move a disc");
			string input = .ReadLine().ToUpper();

			if ((input == "A") && (input == "B"))
			{
				Disks.Pop();
			}

			Console.ReadLine(); */
		}

		public bool CheckWon(Stack<int> stackInt)
		{
			string StackValue = "";

			foreach(var num in stackInt)
			{
				StackValue += num.ToString();
			}

			return (StackValue == winning_combo); 
		}

		public static string Reverse(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}

	}


}

