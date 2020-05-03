using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes_Villians
{
	class Program
	{
		static void Main(string[] args)
		{
			//Prints out a Citizen, Hero, & Villian
			Citizen();
			Hero();
			badGuy();
		}

		//Asks you for information about a person prints it out
		static void Citizen()
		{
			Console.WriteLine("What is your Name?");
			string inputName = Console.ReadLine();
			Console.WriteLine("What is your nick name?");
			string inputNickName = Console.ReadLine();

			Person citizen = new Person(inputName, inputNickName);

			Console.WriteLine("Hi my name is {0} and my nick name is {1}", citizen.realName, citizen.nickName);
			Console.ReadLine();
		}

		//Asks you for information about a Hero prints it out
		static void Hero()
		{
			Console.WriteLine("What is your Real Name?");
			string inputName = Console.ReadLine();
			Console.WriteLine("What is your Super Hero Name?");
			string inputSuperName = Console.ReadLine();
			Console.WriteLine("What is your Super Power?");
			string SuperAbility = Console.ReadLine();

			SuperHeroes Hero = new SuperHeroes(inputName, inputSuperName, SuperAbility, null);

			Console.WriteLine("I am {0}. My Super Hero name is {1}, and my power is {2}.", Hero.realName, Hero.superHeroName, Hero.superPower);
			Console.ReadLine();
		}

		//Asks you for information about a Villian & prints it out
		static void badGuy()
		{
			Console.WriteLine("What is your Villian Name?");
			string villainName = Console.ReadLine();
			Console.WriteLine("Who is your Nemisis?");
			string rival = Console.ReadLine();

			Villian villain = new Villian(villainName, null, rival);

			Console.WriteLine("I am {0}. My Nemisis is {1}!", villain.realName, villain.nemisis);
			Console.ReadLine();
		}
	}

	//Classes about person, Hero, and Villian. 
	public class Person
	{
		public string realName;
		public string nickName;

		public Person (string initialRealName, string initialNickName)
		{
			this.realName = initialRealName;
			this.nickName = initialNickName;
		}
	}

	public class SuperHeroes : Person
	{
		public string superHeroName;
		public string superPower;

		public SuperHeroes (string initialRealName, string initialSuperName, string initialSuperPower, string initialNickName) : base(initialRealName, initialNickName)
		{
			this.nickName = null;
			this.realName = initialRealName;
			this.superHeroName = initialSuperName;
			this.superPower = initialSuperPower;
		}
	}

	public class Villian : Person
	{
		public string nemisis;

		public Villian(string initialRealName, string initialNickName, string initialNemisis) : base(initialRealName, initialNickName)
		{
			this.nickName = null;
			this.realName = initialRealName;
			this.nemisis = initialNemisis;
		}
	}
}
