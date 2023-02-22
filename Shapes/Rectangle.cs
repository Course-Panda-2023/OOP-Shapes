using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Square
    {
        protected int width;

        public Rectangle(bool isFull, char representativeChar, int side, int width) : base(isFull, representativeChar, side)
        {
            this.width = width;
        }

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
                for (int j = 0; j < width; j++)
                {
                    Console.Write($"{representativeChar} ");
                }
                Console.WriteLine();
            }
        }

        public override void PrintEmptyShape()
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (IsOutline(i, j, width, side))
                        Console.Write($"{representativeChar} ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public override void UpdateWidth(int width)
        {
            this.width = width;
        }
    }
}
