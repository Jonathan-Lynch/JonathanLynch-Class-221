using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public struct Position
    {
        public int row { get; private set; }
        public int col { get; private set; }
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    public enum Color { White, Black }

    public class Checker
    {
        public String Symbol { get; private set; }
        public Color Team { get; private set; }
        public Position Position { get; set; }

        public Checker(Color team, int row, int col)
        {
            //Black checker piece
            if (team == Color.Black)
            {
                int symbol = int.Parse("25FE", System.Globalization.NumberStyles.HexNumber);    
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.Black;
            }
            //White checker piece
            else
            {
                int symbol = int.Parse("25FC", System.Globalization.NumberStyles.HexNumber);  
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.White;
            }

            Position = new Position(row, col);
        }
    }
}
