using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIShape
{
    internal class Square : Shape
    {

        private int edge;


        public Square(bool fillIn, char idChar, int edge) : base(fillIn, idChar)
        {
            this.edge = edge;
        }







        public override void PrintNoFill()
        {
            for (int i = 0; i < edge; i++)
            {
                for (int j = 0; j < edge; j++)
                {
                    if (i == 0 || i + 1 == edge)
                        Console.Write("#");
                    else if (j == 0 || j + 1 == edge)
                        Console.Write("#");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

        public override void PrintFill()
        {
            for (int i = 0; i < edge; i++)
            {
                for (int j = 0; j < edge; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
