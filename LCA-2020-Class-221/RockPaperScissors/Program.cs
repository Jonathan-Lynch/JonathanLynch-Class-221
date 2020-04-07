using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	class Program
	{
		//Try to ask there name and use there name whether they win or lose, and have them play against the evil version of themselves.
		static void Main(string[] args)
		{

			string inputPlayer, inputCpu;
			int randomInt;
			bool playAgain = true;

			while (playAgain)
			{

				

				Console.WriteLine("Choose Rock, Paper or Scissors");
				inputPlayer = Console.ReadLine().ToUpper();

				Random Random = new Random();
				randomInt = Random.Next(1, 4);

				switch (randomInt)
					{
						//Rock
						case 1:
							inputCpu = "ROCK";
							Console.WriteLine("Computer Chose ROCK!");
							if (inputPlayer == "ROCK")
							{
								Console.WriteLine("Its a Draw!");
							}
							else if (inputPlayer == "PAPER")
							{
								Console.WriteLine("Player Wins!");
							}
							else if (inputPlayer == "SCISSORS")
							{
								Console.WriteLine("Computer Wins!");
							}
							break;
						//Paper
						case 2:
							inputCpu = "PAPER";
							Console.WriteLine("Computer Chose PAPER");
							if (inputPlayer == "ROCK")
							{
								Console.WriteLine("Computer Wins!");
							}
							if (inputPlayer == "PAPER")
							{
								Console.WriteLine("Its a Draw!");
							}
							if (inputPlayer == "SCISSORS")
							{
								Console.WriteLine("Player Wins!");
							}
							break;
						//Scissors
						case 3:
							inputCpu = "SCISSORS";
							Console.WriteLine("Computer chose SCISSORS");
							if (inputPlayer == "ROCK")
							{
								Console.WriteLine("Player Wins!");
							}
							if (inputPlayer == "PAPER")
							{
								Console.WriteLine("Computer Wins");
							}
							if (inputPlayer == "SCISSORS")
							{
								Console.WriteLine("Its a Draw!");
							}
							break;
					}

					
			}

			/////
		}
	}
}
