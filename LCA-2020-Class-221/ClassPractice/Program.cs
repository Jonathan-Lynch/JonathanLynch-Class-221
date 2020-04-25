using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
	class Program
	{
		static void Main(string[] args)
		{

			person();
		}

		static void person()
		{
			Person jack = new Person("Jack", "Kane", ".V.");
		 /*	jack.firstName = "Jack";
			jack.lastName = "Kane";
			jack.middleName = ".V."; */
			jack.age = 23;

			Console.WriteLine("{0} {1} {2} is {3} years old.",
				jack.firstName, jack.middleName, jack.lastName, jack.age);
			Console.ReadLine();

			//jack.firstName = "Steven";
			jack.age = 7;

			Console.WriteLine("{0} {1} {2} is {3} years old.",
				jack.firstName, jack.middleName, jack.lastName, jack.age);
			Console.ReadLine();
		}

		static void carLot()
		{
			Car car1 = new Car();

			car1.make = "honda";
			car1.model = "civic";
			car1.vin = "12345";
			car1.numDoors = 4;

			Car anyName = new Car();

			anyName.make = "Spuer";
			anyName.model = "Galant";
			anyName.vin = "y2k";
			anyName.numDoors = 9;

			Console.WriteLine("car1 is {0} {1} with {2} doors.",
				car1.make, car1.model, car1.numDoors);
			Console.WriteLine("anyName is {0} {1} with {2} doors and {3}.",
				anyName.make, anyName.model, anyName.numDoors, anyName.vin);
			Console.ReadLine();
		}
	}

	public class Person
	{
		public string firstName {get; private set;}
		public string lastName;
		public string middleName;
		public int age;
		private string fullName;

		public Person(string autoFirstName, string autoLastName, string autoMiddleName)
		{
			this.firstName = autoFirstName;
			this.lastName = autoLastName;
			this.middleName = autoMiddleName;
			this.fullName = this.firstName + " " + this.middleName + " " + this.lastName;
		}
	}

	public class Car
	{
		public string make;
		public string model;
		public string vin;
		public int numDoors;
	}

}
