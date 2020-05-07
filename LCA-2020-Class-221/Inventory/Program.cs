using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
	class Program
	{
		static void Main(string[] args)
		{
			List<IRentable> rentals = new List<IRentable>();
			rentals.Add(new Boat("HouseBoat", "Floats on Water", 12));
			rentals.Add(new Car("Herbie", "He is very competitive", 53));
			rentals.Add(new House("Vila", "Its fancy! because it sounds fancy!", 4));

			foreach (var item in rentals)
			{
				Console.WriteLine($"{item.getDescription()} and its cost is ${item.getRate()}");
			}
			Console.ReadLine();
		}
	}

	public interface IRentable
	{
		decimal getRate();
		string getDescription();
	}

	class Boat : IRentable
	{
		string type;
		string desc;
		decimal rate = 60;
		int hour;
		
		public Boat (string type, string desc, int hour)
		{
			this.type = type;
			this.desc = desc;
			this.hour = hour;
		}

		public string getDescription()
		{
			string wholeDesc = type + " " + desc;
			return wholeDesc;
		}

		public decimal getRate()
		{
			decimal ratePerDay = rate * hour;
			return ratePerDay;
		}
	}

	class Car : IRentable
	{
		string type;
		string desc;
		decimal rate = 85;
		int day;

		public Car (string type, string desc, int day)
		{
			this.type = type;
			this.desc = desc;
			this.day = day;
		}

		public string getDescription()
		{
			string wholeDesc = type + " " + desc;
			return wholeDesc;
		}

		public decimal getRate()
		{
			decimal ratePerRent = rate * day;
			return ratePerRent;
		}
	}

	class House : IRentable
	{
		string type;
		string desc;
		decimal rate = 700;
		int month;

		public House(string type, string desc, int month)
		{
			this.type = type;
			this.desc = desc;
			this.month = month;
		}

		public string getDescription()
		{
			string wholeDesc = type + " " + desc;
			return wholeDesc;
		}

		public decimal getRate()
		{
			decimal ratePerMonth = rate * month;
			return ratePerMonth;
		}
	}
}
