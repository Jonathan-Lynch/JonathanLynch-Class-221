using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
	class StartGame
	{
	}

    class Program
    {
        public static void Main(String[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }
}
