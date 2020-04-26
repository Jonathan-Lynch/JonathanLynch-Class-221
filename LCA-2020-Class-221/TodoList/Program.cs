using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
	class Program
	{
		static void Main(string[] args)
		{
			var ToDoList = new List<ToDoItem>();

			bool finished = true;

			//loops the program until finished
			do
			{
				//asks if you want to add to the list or not
					Console.WriteLine("Do you want to add a item to your To-Do-List?y/n");
					string answer = Console.ReadLine();
				
				
				//checks answer and responds according to what you type
				if (answer == "y")
				{
					ToDoItem Task = new ToDoItem();

					Console.WriteLine("What is the description of the task?");
					Task.description = Console.ReadLine();

					Console.WriteLine("What is the Due Date of your task?");
					Task.dueDate = Console.ReadLine();

					Console.WriteLine("What is the Priority of your task?");
					Task.priority = Console.ReadLine();

					ToDoList.Add(Task);

					finished = false;
				}
				else if (answer == "n")
				{
						
						finished = true;
				}
				else
				{
					finished = true;
				}

			} while (!finished);
			
			//prints the list when done
			foreach (var item in ToDoList)
			{
				Console.WriteLine(item.description + " " + item.dueDate + " " + item.priority);
				
			}
			Console.ReadLine();
		}
	}

	public class ToDoItem
	{
		public string description;
		public string dueDate;
		public string priority;

	}
}
