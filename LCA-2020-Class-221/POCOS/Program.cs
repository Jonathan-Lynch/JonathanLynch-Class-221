using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOS
{
	class Program
	{
		static void Main(string[] args)
		{
			//License();
			Publishing();
			//AirPort();
		}

		static void License()
		{
			//creates a new driver license
			DriverLicense person = new DriverLicense();
			bool checkNum = true;

			//asks for a first name
			Console.WriteLine("What is your first name?");
			person.firstName = Console.ReadLine();

			//asks for a last name
			Console.WriteLine("What is your last name?");
			person.lastName = Console.ReadLine();

			//ask for a gender
			Console.WriteLine("What is your gender?");
			person.gender = Console.ReadLine();

			//asks for a number and checks if it is a number and if it isnt then it will loop
			do
			{
				Console.WriteLine("Write any number of numbers");
				person.licenseNumber = Console.ReadLine();

				int result;
				checkNum = int.TryParse(person.licenseNumber, out result);

			} while (!checkNum);

			//prints out the results
			Console.WriteLine("Your Driver License info is | first Name: " + person.firstName + " | Last Name: " + person.lastName + " | Gender: " + person.gender + " | License Number: " + person.licenseNumber + " |");
			Console.ReadLine();
		}

		static void Publishing()
		{
			//creates a book
			Book product = new Book();
			bool checkNum = true;

			//asks for the title
			Console.WriteLine("What is the Title of your book?");
			product.title = Console.ReadLine();

			//asks for a author
			Console.WriteLine("Who is the Author?");
			product.authors = Console.ReadLine();
			Console.WriteLine("is there another author? y/n");
			Console.ReadLine().ToLower();				

			//asks for the number of pages and loops if it isnt a number
			do
			{
				Console.WriteLine("What is the number of pages of your book?");
				product.pages = Console.ReadLine();

				int result;
				checkNum = int.TryParse(product.pages, out result);

			} while (!checkNum);

			//asks for the SKU
			Console.WriteLine("What is the Stock Keeping Unit of your book?");
			product.SKU = Console.ReadLine();

			//asks for the price
			do
			{
				Console.WriteLine("What is the Price of your book?");
				product.price = Convert.ToDouble(Console.ReadLine());

				double result;
				checkNum = double.TryParse(product.pages, out result);

			} while (!checkNum);

			//prints out the result
			Console.WriteLine("The Title is '" + product.title + "' and the Author: " + " and the number of the pages is " + product.pages + " and the SKU: " + product.SKU + " and the Price: " + product.price);
			Console.ReadLine();
		}

		static void AirPort()
		{
			AirPlane plane = new AirPlane();
			Console.WriteLine("Who Manufactured your plane?");
			plane.manufacturer = Console.ReadLine();
			Console.WriteLine("What is the Model?");
			plane.model = Console.ReadLine();
			Console.WriteLine("What is the Varient?");
			plane.varient = Console.ReadLine();
			Console.WriteLine("What is the Capacity of the Aircraft?");
			plane.capacity = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("What is the number of Engines in your Aircraft?");
			plane.engines = Convert.ToInt32(Console.ReadLine());
		}
	}

	public class DriverLicense
	{
		public string firstName;
		public string lastName;
		public string gender;
		public string licenseNumber;
	}

	public class Book
	{
		public string title;
		public string authors;
		public string pages;
		public string SKU;
		public double price;
	}

	public class AirPlane
	{
		public string manufacturer;
		public string model;
		public string varient;
		public int capacity;
		public int engines;
	}

}
