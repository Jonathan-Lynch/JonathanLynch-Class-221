using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class Program
	{
		public static string[,] gameBoard;

		static void Main(string[] args)
		{

			Board();
			
			int movesPlayed = 0;
			string player = "X";
			bool inGame = true;
			bool playAgain = true;
			bool fInvalidEntry = false;

			while (playAgain)
			{
				//switches players
				if (!fInvalidEntry)
				{
					if (player == "X")
					{
						player = "O";
					}
					else
					{
						player = "X";
					}
				}
				Console.Clear();
				visualBoard();
				Console.WriteLine("Type a number equal to any in the square");
				string answer = Console.ReadLine();

				//tells if its not a valid number or if it is a letter
				if (!int.TryParse(answer, out int number))
				{
					Console.WriteLine("Not a Valid Move, Try Again");
					Console.ReadLine();
					continue;
				}
				if (answer.Length > 1)
				{
					Console.WriteLine("Not a Valid Move, Try Again");
					Console.ReadLine();
					continue;
				}

				fInvalidEntry = false;

				//place a marker at square 1
				if (answer == "1" && gameBoard[0, 0] == "1")
				{
					gameBoard[0, 0] = player;
				}
				//place a marker at square 2
				else if (answer == "2" && gameBoard[0, 1] == "2")
				{
					gameBoard[0, 1] = player;
				}
				//place a marker at square 3
				else if (answer == "3" && gameBoard[0, 2] == "3")
				{
					gameBoard[0, 2] = player;
				}
				//place a marker at square 4
				else if (answer == "4" && gameBoard[1, 0] == "4")
				{
					gameBoard[1, 0] = player;
				}
				//place a marker at square 5
				else if (answer == "5" && gameBoard[1, 1] == "5")
				{
					gameBoard[1, 1] = player;
				}
				//place a marker at square 6
				else if (answer == "6" && gameBoard[1, 2] == "6")
				{
					gameBoard[1, 2] = player;
				}
				//place a marker at square 7
				else if (answer == "7" && gameBoard[2, 0] == "7")
				{
					gameBoard[2, 0] = player;
				}
				//place a marker at square 8
				else if (answer == "8" && gameBoard[2, 1] == "8")
				{
					gameBoard[2, 1] = player;
				}
				//place a marker at square 9
				else if (answer == "9" && gameBoard[2, 2] == "9")
				{
					gameBoard[2, 2] = player;
				}
				//Not a Valid Move
				else
				{
					fInvalidEntry = true;
					Console.WriteLine("Invalid Move, Press 'Enter' to try again.");
					Console.ReadLine();
				}

				inGame = !VictoryCheck(player, movesPlayed);
				movesPlayed++;

				//when game is finished asks if they want to play again.
				if (!inGame)
				{
					Console.WriteLine("Do you want to play again?(yes/no)");
					string loopGame = Console.ReadLine().ToUpper();

					if (loopGame == "YES")
					{
						playAgain = true;
						Board();
					}

					if (loopGame == "NO")
					{
						playAgain = false;
					}
				}
			}
		}
		

		static bool VictoryCheck(string player, int movesPlayed)
		{
			bool fWinner = true;

			// 1 row
			if (player == gameBoard[0, 0] && player == gameBoard[0, 1] && player == gameBoard[0, 2])
			{
				
				Console.WriteLine(player + " has Won!");
				Console.ReadLine();
			}
			// 2 row
			else if (player == gameBoard[1, 0] && player == gameBoard[1, 1] && player == gameBoard[1, 2])
			{
				Console.WriteLine(player + " has Won!");
				Console.ReadLine();
			}
			// 3 row
			else if (player == gameBoard[2, 0] && player == gameBoard[2, 1] && player == gameBoard[2, 2])
			{
				Console.WriteLine(player + " has Won!");
				Console.ReadLine();
			}
			// 1 column
			else if (player == gameBoard[0, 0] && player == gameBoard[1, 0] && player == gameBoard[2, 0])
			{
				Console.WriteLine(player + " has Won!");
				Console.ReadLine();
			}
			// 2 column
			else if (player == gameBoard[0, 1] && player == gameBoard[1, 1] && player == gameBoard[2, 1])
			{
				Console.WriteLine(player + " has Won!");
				Console.ReadLine();
			}
			// 3 column
			else if (player == gameBoard[0, 2] && player == gameBoard[1, 2] && player == gameBoard[2, 2])
			{
				Console.WriteLine(player + " has Won!");
				Console.ReadLine();
			}
			// top left to bottom right
			else if (player == gameBoard[0, 0] && player == gameBoard[1, 1] && player == gameBoard[2, 2])
			{
				Console.WriteLine(player + " has Won!");
				Console.ReadLine();
			}
			// top right to bottom left
			else if (player == gameBoard[0, 2] && player == gameBoard[1, 1] && player == gameBoard[2, 0])
			{
				Console.WriteLine(player + " has Won!");
				Console.ReadLine();
			}
			//tells you if game is a draw
			else if (movesPlayed == 8)
			{
				Console.WriteLine("Draw!");
				
			}
			else
			{
				fWinner = false;
			}

			return fWinner; 
		}

		static void visualBoard()
		{
			//prints the board
			for (int row=0; row< 3; row++)
			{
				Console.WriteLine(" " + gameBoard[row, 0] + " | " + gameBoard[row, 1] + " | " + gameBoard[row, 2]);
				for (int col=0; col<1; col++)
				{
					Console.WriteLine("---+---+---");
				}
			}
		}

		static void Board()
		{
			gameBoard = new string[3, 3]
			{
				//prints number on the board
				{ "1", "2", "3"},
				
				{ "4", "5", "6"},

				{ "7", "8", "9"},

			};
		}


	}
}
