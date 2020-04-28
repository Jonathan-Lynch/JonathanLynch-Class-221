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
			//sets the towers and 4 disks up
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

			var input = "";
			var inputTo = "";

			//loops the game until the game is won
			do
			{
				//prints the board
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

				//loops til valid move
				do
				{
					//asks you to pick a tower
					Console.WriteLine("Type in A, B, or C to target and move a disc");
					input = Console.ReadLine().ToUpper().ToUpper();
					
					//asks you where you want to put it
					Console.WriteLine("Type in where you want it to go");
					inputTo = Console.ReadLine().ToUpper();

					//wont put larger numbers and smaller numbers and then pops and push the number to the inputed place
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

				} while (!invalid);

			} while (!CheckWon(towers[inputTo]));

			Console.WriteLine("You Win! Press Enter to close");
			Console.ReadLine();
		}

		public static bool CheckWon(Stack<int> stackInt)
		{
			string StackValue = "";

			foreach(var num in stackInt)
			{
				StackValue += num.ToString();
			}

			return (StackValue == winning_combo);
		}

		//reverse the disks so they are in proper arrangment
		public static string Reverse(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}

