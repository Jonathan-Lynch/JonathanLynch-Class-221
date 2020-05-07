using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
	class Program
	{
		//Prints out a list of Cars and Trucks
		static void Main(string[] args)
		{
			CarLot newCarLot = new CarLot("Lubbock Car Lot");
			newCarLot.AddVehicle(new Car("W3Z78", "Honda", "Accord", 5000, "Sedan", "4"));
			newCarLot.AddVehicle(new Truck("something333", "Toyota", "Tundra", 7000, "6'3 by 4"));
			newCarLot.AddVehicle(new Car("53", "Volkswagon", "Herbie!", 53000, "Beetle", "2"));

			//loops through the list of vehicles made & actually prints the information
			foreach(var item in newCarLot.StoreVehicles())
			{
				item.PrintInformation();
			}
			Console.ReadLine();
		}
	}

	//this stores & adds cars
	class CarLot
	{

		public string name;
		List<Vehicle> AutoMobiles = new List<Vehicle>();

		public CarLot(string initialname)
		{
			name = initialname;
		}

		//adds and returns vehicles back to the list
		public void AddVehicle(Vehicle AutoMobile)
		{
			AutoMobiles.Add(AutoMobile);
		}

		public List<Vehicle> StoreVehicles()
		{
			return AutoMobiles;
		}
	}

	abstract class Vehicle
	{
		public string licenseNumber;
		public string make;
		public string model;
		public decimal price;

		public Vehicle(string initialLicense, string initialMake, string initialModel, decimal initialPrice)
		{
			licenseNumber = initialLicense;
			make = initialLicense;
			model = initialModel;
			price = initialPrice;
		}

		//allow the program to print out the information
		public virtual void PrintInformation()
		{
			Console.WriteLine($"License: {licenseNumber}, Make: {make}, Model: {model}, and Cost: {price}");
		}
	}

	class Car : Vehicle
	{

		public string type;
		public string doors;

		public Car (string initialLicense, string initialMake, string initialModel, decimal initialPrice, string initialType, string initialDoors) : base(initialLicense, initialMake, initialModel, initialPrice)
		{
			licenseNumber = initialLicense;
			make = initialLicense;
			model = initialModel;
			price = initialPrice;
			type = initialType;
			doors = initialDoors;
		}

		//prints out all the stored information about a car
		public override void PrintInformation()
		{
			Console.WriteLine($"License: {licenseNumber}, Make: {make}, Model: {model}, Cost: {price}, Type: {type}, Doors: {doors}");
		}
	}

	class Truck : Vehicle
	{
		public string bedSize;

		public Truck (string initialLicense, string initialMake, string initialModel, decimal initialPrice, string initialBedSize) : base(initialLicense, initialMake, initialModel, initialPrice)
		{
			licenseNumber = initialLicense;
			make = initialLicense;
			model = initialModel;
			price = initialPrice;
			bedSize = initialBedSize;
		}

		//prints out all the stored information about a truck
		public override void PrintInformation()
		{
			Console.WriteLine($"License: {licenseNumber}, Make: {make}, Model: {model}, Cost: {price}, Bed Size: {bedSize}");
		}
	}
}
