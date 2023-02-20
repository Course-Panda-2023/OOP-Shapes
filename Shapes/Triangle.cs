using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        protected int height;

        public Triangle(bool full, char representativeChar, int height) : base(full, representativeChar)
        {
            this.height = height;
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
            for (int i = 0; i < height; i++)
            {
                for (int j = height - i; j > 0; j--)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                    Console.Write(representativeChar + " ");
                Console.WriteLine();
            }
        }

        public override void PrintEmptyShape()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = height - i; j > 0; j--)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                {
                    if (i == 0 || j == 0 || j == i || i == height - 1)
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
            this.height = heigth;
        }
    }
}
