using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{

    class Program
    {
        public static Color playerTurn = Color.White;
        static void Main(string[] args)
        {
            
            Game game = new Game();
            game.Start();
            Console.OutputEncoding = Encoding.UTF8;
            Console.ReadKey();
        }
    }

}
