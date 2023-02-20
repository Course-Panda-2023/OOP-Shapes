using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rhombus : Square
    {
        public Rhombus(bool full, char representativeChar, int side) : base(full, representativeChar, side) { }

        public override void PrintShape()
        {
            if (full)
                PrintFullShape();
            else
                PrintEmptyShape();
        }

        public override void PrintFullShape()
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write(representativeChar + " ");
                }
                Console.WriteLine();
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("  ");
                }
            }
        }

        public override void PrintEmptyShape()
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if (i == 0 || j == 0 || j == side - 1 || i == side - 1)
                        Console.Write(representativeChar + "  ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine();
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("  ");
                }
            }
        }
    }
}
