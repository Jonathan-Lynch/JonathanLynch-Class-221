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
				Console.WriteLine("First to 3 points Wins!");
				Console.WriteLine("What is your Name?");
				string playerName = Console.ReadLine();

				string cpuName = "Evil " + playerName;

				int playerScore = 0;
				int cpuScore = 0;

				while (playerScore < 3 && cpuScore < 3)
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
								playerScore++;
							}
							else if (inputPlayer == "SCISSORS")
							{
								Console.WriteLine("Computer Wins!");
								cpuScore++;
							}
							break;
						//Paper
						case 2:
							inputCpu = "PAPER";
							Console.WriteLine("Computer Chose PAPER");
							if (inputPlayer == "ROCK")
							{
								Console.WriteLine("Computer Wins!");
								cpuScore++;
							}
							if (inputPlayer == "PAPER")
							{
								Console.WriteLine("Its a Draw!");
							}
							if (inputPlayer == "SCISSORS")
							{
								Console.WriteLine("Player Wins!");
								playerScore++;
							}
							break;
						//Scissors
						case 3:
							inputCpu = "SCISSORS";
							Console.WriteLine("Computer chose SCISSORS");
							if (inputPlayer == "ROCK")
							{
								Console.WriteLine("Player Wins!");
								playerScore++;
							}
							if (inputPlayer == "PAPER")
							{
								Console.WriteLine("Computer Wins");
								cpuScore++;
							}
							if (inputPlayer == "SCISSORS")
							{
								Console.WriteLine("Its a Draw!");
							}
							break;
					}
					Console.WriteLine(playerName + " " + "Score: " + playerScore + " | " + cpuName + " " + "Score: " + cpuScore);


					if (playerScore == 3)
					{
						Console.WriteLine(playerName + " is the Grand Winner! good for you.");
					}
					else if (cpuScore == 3)
					{
						Console.WriteLine(cpuName + " is the Grand Winner! Wow, I guess " + cpuName + " is Smarter than you.");
					}

					
				}

				Console.WriteLine("Do you want to play again?(yes/no)");
				string loopGame = Console.ReadLine().ToUpper();

				if (loopGame == "YES")
				{
					playAgain = true;
				}
				if (loopGame == "NO")
				{
					playAgain = false;
				}

			}

			/////
		}
	}
}
