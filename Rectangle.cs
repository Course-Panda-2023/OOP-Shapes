using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIShape
{
    internal class Rectangle : Shape
    {
        int edgeX, edgeY;
        public Rectangle(bool fillIn, char idChar,int edgeX,int edgeY) : base(fillIn, idChar)
        {
            this.edgeX = edgeX;
            this.edgeY = edgeY; 

        }

        public override void PrintFill()
        {
            for (int i = 0; i < edgeX; i++)
            {
                for (int j = 0; j < edgeY; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        public override void PrintNoFill()
        {
            for (int i = 0; i < edgeX; i++)
            {
                for (int j = 0; j < edgeY; j++)
                {
                    if (i == 0 || i + 1 == edgeX)
                        Console.Write("#");
                    else if (j == 0 || j + 1 == edgeY)
                        Console.Write("#");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    
    }
}
