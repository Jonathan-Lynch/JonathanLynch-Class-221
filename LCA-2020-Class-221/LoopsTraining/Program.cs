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

			forEachLoop();

			whileLoop();

			doWhileLoop();

			arrayPractice();

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

		static void forEachLoop()
		{
			string[] colors = new string[] {"yellow", "blue", "red", "green" };

			foreach (string cl in colors)
			{
				Console.WriteLine(cl);
				//Console.ReadLine();
			}
			Console.ReadLine();
		}

		static void whileLoop()
		{
			int number = 1;
			
			while (number < 10)
			{
				Console.WriteLine(number);
				number++;
				if (number == 10)
				{
					number = number - 1;
					Console.WriteLine(number);
				}
			}

			while (number > 0)
			{
				Console.WriteLine(number);
				number++;
			}
			Console.ReadLine();

		}

		static void doWhileLoop()
		{
			int counter = 999; // try int counter = -999

			do
			{
				Console.WriteLine("Counter = {0}", counter);
				counter++; //since it is already true it wont add anything
			} while (counter < 0);
			Console.ReadLine();

		}


		static void arrayPractice()
		{
			string[] students = new string[10];
			students[0] = "Mike";
			students[1] = "Mary";
			students[3] = "Mark";

			Console.WriteLine(students[0]);
			Console.WriteLine(students[1]);
			Console.WriteLine(students[2]);
			Console.WriteLine(students[3]);  

			string[] otherStudents = {"James", "Jacob", "John", "Jenny" };

			Console.WriteLine(otherStudents[0]);
			Console.WriteLine(otherStudents[1]);
			Console.WriteLine(otherStudents[2]);
			Console.WriteLine(otherStudents[3]);

			string[] lastStudents;
			lastStudents = new string[] {"Adam", "Ann", "Amber", "Alley"};

			Console.ReadLine();


			int[] number = { 0, 0, 1, 2, 3, 5, 8, 13, 21 };
			int[] primes = {1,2,3,5,7,11,13,17,19};

			bool[] someFlags = { true, false, false, true, false, true };
			char[] multipleChoiceAnswers = {'A', 'D', 'A', 'E', 'B '}
		}

		static void arrayExperiments()
		{
			int[] numArray = { 6, 8, -6, 9, 10 };

			//Length
			Console.WriteLine(numArray.Length);


			//Sort()
			Array.Sort(numArray);

			foreach (var num in numArray)
			{
				Console.WriteLine(num);
			}

			//IndexOf()

			//Prints the location if the item does exist in the array
			Console.WriteLine(Array.IndexOf(numArray, 9));

			//Prints -1 if the number does not exist
			Console.WriteLine(Array.IndexOf(numArray, 100));

			//Copy() takes in 3 arguments: (array being copied, the array we are copying to, and the number of items). 
			string[] source = { "apple", "carrot", "banana", "tomato", "grape", "pear" };
			string[] destination = { "pineapple", "blueberry", "raspberry", "cherry" };

			Array.Copy(source, destination, 3);

			foreach (var num in destination)
			{
				Console.WriteLine(num);
			}

			//The destination array is changed while the course array remains the same.
		}


		///
	}
}
