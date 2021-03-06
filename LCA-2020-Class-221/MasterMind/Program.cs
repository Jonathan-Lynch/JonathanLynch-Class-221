﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
	class Program
	{
		static void Main(string[] args)
		{

			
			bool playAgain = true;
			bool gameLoop = true;
			bool invalidEntry = false;

			//sets the game up and resets it when you finish
			while (playAgain) {

				Console.Clear();
				string cpuColor = masterMindColCPU();
				string cpuPos = masterMindPosCPU("POS");
				
				//loops the game were you keep guessing until you guess correctly
				while (gameLoop) {

					string colorPl = "";
					string numberPl = "";

					//asks you to pick a color and tells if it is invalid or valid
					do
					{
						Console.WriteLine("Pick a color between Red, Blue, and Yellow.");
						colorPl = Console.ReadLine().ToUpper();
						invalidEntry = false;

						if ((colorPl != "RED") && (colorPl != "BLUE") && (colorPl != "YELLOW"))
						{
							Console.WriteLine("Invalid Entry, Try Again");
							invalidEntry = true;
						}
					} while (invalidEntry);
					
					//asks you if to pick a position and tells if it is invalid or valid
					do {
						Console.WriteLine("Pick a Number between 1-3");
						numberPl = Console.ReadLine().ToUpper();
						invalidEntry = false;

						if ((numberPl != "1") && (numberPl != "2") && (numberPl != "3"))
						{
							Console.WriteLine("Invalid Entry, Try again");
							invalidEntry = true;
						}
					} while (invalidEntry);
					
					//tells you how close you are from winning the game
						if ((colorPl == cpuColor) && (numberPl == cpuPos))
						{
							Console.WriteLine("2-0");
							gameLoop = false;
						}
						else if ((colorPl == cpuColor) && (numberPl != cpuPos))
						{
							Console.WriteLine("1-0");
						}
						else if ((colorPl != cpuColor) && (numberPl == cpuPos))
						{
							Console.WriteLine("0-1");
						}
						else if ((colorPl != cpuColor) && (numberPl != cpuPos))
						{
							Console.WriteLine("0-0");
						}
					
				}

				//asks if you want to play again
				Console.WriteLine("Do you want to play again?(yes/no)");
				string loopGame = Console.ReadLine().ToUpper();

				if (loopGame == "YES")
				{
					playAgain = true;
					gameLoop = true;
				}
				if (loopGame == "NO")
				{
					playAgain = false;
				}
			}
		}

		//cpu chooses a color
		static string masterMindColCPU()
		{
			string returnValue = "";

			int randomCol;

			Random Random = new Random();
			randomCol = Random.Next(1, 4);

			switch (randomCol)
			{
				case 1:
					returnValue = "RED";
					break;
				case 2:
					returnValue = "BLUE";
					break;
				case 3:
					returnValue = "YELLOW";
					break;
			}
			
			return returnValue;
		}

		//cpu chooses a number
		static string masterMindPosCPU(string returnType)
		{
			int randomPos;
			string returnValue = "";

			if (returnType == "POS") { }

			Random Random = new Random();
			randomPos = Random.Next(1, 4);
			switch (randomPos)
			{
				case 1:
					returnValue = "1";
					break;
				case 2:
					returnValue = "2";
					break;
				case 3:
					returnValue = "3";
					break;
			}
			return returnValue;
		}
	}
}
 