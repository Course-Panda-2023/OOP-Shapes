using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIShape
{
    internal class Rhombus : Shape
    {
        private int diagonal;
        public Rhombus(bool fillIn, char idChar,int diagonal) : base(fillIn, idChar)
        {
            if (diagonal % 2 == 0)
                this.diagonal = diagonal+1;
            else
                this.diagonal = diagonal;
        }

        public override void PrintFill()
        {
            int halfSize = diagonal / 2;
            for (int row = 0; row < diagonal; row++)
            {
                // Loop through the columns of the rhombus
                for (int col = 0; col < diagonal; col++)
                {
                    // Determine if the current cell should be a space or an asterisk
                    if (Math.Abs(col - halfSize) + Math.Abs(row - halfSize) <= halfSize)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); // Move to the next line
            }

        }

        public override void PrintNoFill()
        {
            int halfSize = diagonal / 2;
            for (int row = 0; row < diagonal; row++)
            {
                // Loop through the columns of the rhombus
                for (int col = 0; col < diagonal; col++)
                {
                    // Determine if the current cell should be a space or an asterisk
                    if (Math.Abs(col - halfSize) + Math.Abs(row - halfSize) == halfSize)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); // Move to the next line
            }
        }
    }
}
