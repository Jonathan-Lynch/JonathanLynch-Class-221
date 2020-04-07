using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			hello();

			addition();

			catDog();

			oddEvent();

			inches();

			echo();

			killGrams();

			date();

			age();

			guess();
		}

		//Geets and says Goodby with the inputed name
		static void hello()
		{
			Console.WriteLine("What is your Name?");
			string answer = Console.ReadLine();
			Console.WriteLine("Goodbye" + " " + answer + "!");
			Console.ReadLine();
		}

		//adds the 2 inputed numbers
		static void addition()
		{	
			Console.WriteLine("Write Number one: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write Number two: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			int bothNum = num1 + num2;
			int total = bothNum;
			Console.WriteLine(total);
			Console.ReadLine();
		}

		//Meows or Barks if you type in Dog or Cat
		static void catDog()
		{
			var CapDog = "Dog";
			var lowDog = "dog";
			var CapCat = "Cat";
			var lowCat = "cat";
			Console.WriteLine("Cat or Dog");
			string answer = Console.ReadLine();
			if (answer == lowDog)
			{
				Console.WriteLine("Barks");
				Console.ReadLine();
			}
			if (answer == CapDog)
			{
				Console.WriteLine("Barks");
				Console.ReadLine();
			}
			if (answer == lowCat)
			{
				Console.WriteLine("Meows");
				Console.ReadLine();
			}
			if (answer == CapCat)
			{
				Console.WriteLine("Meows");
				Console.ReadLine();
			}
		}

		//Tells you if the number inputed is even or odds
		static void oddEvent()
		{
			Console.WriteLine("Type a Number");
			int num1, rem1;
			num1 = Convert.ToInt32(Console.ReadLine());
			rem1 = num1 % 2;
			if (rem1 == 0)
				Console.WriteLine("{0} is an even.", num1);
			else
				Console.WriteLine("{0} is an odd.", num1);
			Console.ReadLine();
		}

		//converts feet to inches
		static void inches()
		{
			Console.WriteLine("Write a number of ft");
			int feet = Convert.ToInt32(Console.ReadLine());
			int inches;
			inches = feet * 12;
			Console.WriteLine(inches + "in.");
			Console.ReadLine();
		}

		//repeats the inputted word 3 times with once in all caps and twice lower case
		static void echo()
		{
			Console.WriteLine("Write a Word");
			string answer = Console.ReadLine();
			string upperCase = answer.ToUpper();
			string lowerCase = answer.ToLower();
			Console.WriteLine(upperCase + " " + lowerCase + " " + lowerCase);
			Console.ReadLine();
		}

		//converts pounds to kilograms
		static void killGrams()
		{
			decimal pounds;
			decimal poundsConverted;
			decimal half = Convert.ToDecimal(2.2);
			Console.WriteLine("Write a Weight of pounds");
			pounds = Convert.ToDecimal(Console.ReadLine());
			poundsConverted = pounds / half;
			Console.WriteLine(poundsConverted);
			Console.ReadLine();
		}

		//what is the current date and time
		static void date()
		{
			Console.WriteLine(DateTime.Now);
			Console.ReadLine();
		}

		//when you type in your birthday, tells you your age
		static void age()
		{
			Console.WriteLine("Enter your birtdate: ");
			DateTime birthDate = DateTime.Parse(Console.ReadLine());

			int Days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (birthDate.Year * 365 + birthDate.DayOfYear);
			int Years = Days / 365;
			string message = (Days >= 365) ? "Your age: " + Years + " years" : "Your age: " + Days + " days";
			Console.WriteLine(message);
			Console.ReadLine();
		}

		//type the word chsarp then you get correct, otherwise you get false
		static void guess()
		{
			Console.WriteLine("Guess a Word");
			string answer = Console.ReadLine();
			if (answer == "chsarp")
			{
				Console.WriteLine("Correct!");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Wrong!");
				Console.ReadLine();
			}
		}

		///
	}
}
