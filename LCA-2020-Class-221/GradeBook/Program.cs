using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
		{

			string name = string.Empty;
			Dictionary<string, string> gradeBook = new Dictionary<string, string>();

			//Ask you for the students name & grades & adds them to the dictionary
			do
			{
					Console.WriteLine("Add a Student's Name or type in quit");
					name = Console.ReadLine().ToLower();

					if (name.Equals("quit")) { break; }

					Console.WriteLine("Type in the Student's grades seperated by spaces");
					string grades = Console.ReadLine();

					gradeBook.Add(name, grades);
				
				
			} while (true);

				int highestGrade = 0;
				int lowestGrade = 0;
				double average = 0.00;


				foreach (var item in gradeBook)
				{
					//tries to convert what was inputed and catches if you put an invalid entry and doesnt break
					try
					{
					int[] singleGrades = Array.ConvertAll<string, int>(gradeBook[item.Key].Split(), Convert.ToInt32);
					
					highestGrade = singleGrades.Max();
					lowestGrade = singleGrades.Min();
					average = singleGrades.Average();

					Console.WriteLine($"{item.Key}\n");
					Console.WriteLine($"Highest Grades = {highestGrade} Lowest Grades = {lowestGrade} Average Grades = {average}");
				}
					catch
					{
					
					}

					

					
				}
				Console.ReadLine();


			
		}
	}

}
