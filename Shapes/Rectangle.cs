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

        public Rectangle(bool full, char representativeChar, int side, int width) : base(full, representativeChar, side)
        {
            this.width = width;
        }

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
                for (int j = 0; j < width; j++)
                {
                    Console.Write(representativeChar + " ");
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
                    if (i == 0 || j == 0 || j == width - 1 || i == side - 1)
                        Console.Write(representativeChar + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public override void Update(bool full, char representativeChar, int heigth, int width)
        {
            this.full = full;
            this.representativeChar = representativeChar;
            this.side = heigth;
            this.width = width;
        }
    }
}
