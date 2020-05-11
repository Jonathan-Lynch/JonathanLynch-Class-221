using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Game
    {
        public string winner;

        private Board board;
        public Game()
        {
            this.board = new Board();
        }

        private bool CheckForWin()
        {
            return board.checkers.All(x => x.Team == Color.White) || board.checkers.All(x => x.Team == Color.Black);
        }

        public void Start()
        {
            DrawBoard();

            while (!CheckForWin())
            {
                ProcessInput();
            }

            Console.WriteLine($"Congratulations {winner} has won!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public bool IsLegalMove(Color player, Position src, Position dest)
        {

            if (src.row < 0 || src.row > 7 || src.col < 0 || src.col > 7
                || dest.row < 0 || dest.row > 7 || dest.col < 0 || dest.col > 7) return false;

            int rowDistance = Math.Abs(dest.row - src.row);
            int colDistance = Math.Abs(dest.col - src.col);

            if (colDistance == 0 || rowDistance == 0) return false;

            if (rowDistance == 0 || colDistance != 1) return false;

            if (rowDistance > 2) return false;

            Checker c = board.GetChecker(src);
            if (c != null)
            {
                return false;
            }
            c = board.GetChecker(dest);

            if (c != null)
            {
                return false;
            }
            if (rowDistance == 2)
            {
                if (IsCapture(src, dest))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }

        public bool IsCapture(Position src, Position dest)
        {
            int rowDistance = Math.Abs(dest.row - src.row);
            int colDistance = Math.Abs(dest.col - src.row);

            if (rowDistance == 2 && colDistance == 2)   
            {
                int rowMid = (dest.row + src.row) / 2;
                int colMid = (dest.col + src.col) / 2;

                Position p = new Position(rowMid, colMid);

                Checker c = board.GetChecker(p);

                Checker player = board.GetChecker(src);

                if (c == null)
                {
                    return false;
                }
                else
                {
                    if (c.Team == player.Team)      
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Checker GetCaptureChecker(Position src, Position dest)
        {

            if (IsCapture(src, dest))
            {
                int rowMid = (dest.row + src.row) / 2;
                int colMid = (dest.col + src.col) / 2;

                Position p = new Position(rowMid, colMid);

                Checker CapturedChecker = board.GetChecker(p);
                return CapturedChecker;
            }
            return null;
        }

        public void ProcessInput()
        {
            Console.WriteLine("Select a checker to move (Row, Column):");
            String[] src = Console.ReadLine().Split(',');
            Console.WriteLine("Select a square to move to (Row, Column):");
            string[] dest = Console.ReadLine().Split(',');

            Position from = new Position(int.Parse(src[0]), int.Parse(src[1]));
            Position to = new Position(int.Parse(dest[0]), int.Parse(dest[1]));

            Checker PlayerChecker = board.GetChecker(from);

            if (PlayerChecker == null)
            {
                Console.WriteLine("There is no checker there.");

            }
            else
            {
                if (this.IsLegalMove(PlayerChecker.Team, from, to))
                {
                    if (this.IsCapture(from, to))
                    {
                        Checker captureChecker = this.GetCaptureChecker(from, to);
                        board.RemoveChecker(captureChecker);
                    }

                    board.MoveChecker(PlayerChecker, to);
                }
                else
                {

                    Console.WriteLine("Move is Invalid");
                }
            }
            
        }

        //I dont know why it wont print out the B/W symbols
        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.checkers)
            {
                grid[c.Position.row][c.Position.col] = c.Symbol;
            }

            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int r = 0; r < 8; r++)
            {
                Console.Write(r);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(" {0}", grid[r][c]);
                }
                Console.WriteLine();
            }
        }


    }
}
