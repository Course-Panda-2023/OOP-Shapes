using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rhombus : Square
    {
        public Rhombus(bool isFull, char representativeChar, int side) : base(isFull, representativeChar, side) { }

        public override void PrintShape()
        {
            if (isFull)
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
                    Console.Write($"{representativeChar}  ");
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
                    if (IsOutline(i, j, side, side))
                        Console.Write($"{representativeChar}  ");
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
