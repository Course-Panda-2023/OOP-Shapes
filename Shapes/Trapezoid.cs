using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Trapezoid : Triangle
    {
        protected int upperBase;

        public Trapezoid(bool isFull, char representativeChar, int side, int upperBase) : base(isFull, representativeChar, side)
        {
            this.upperBase = upperBase;
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
            int temp = upperBase;
            for (int i = 0; i < height; i++)
            {
                for (int k = height - i; k > 1; k--)
                    Console.Write("  ");
                for (int j = 0; j < temp; j++)
                    Console.Write($"{representativeChar} ");
                Console.WriteLine();
                temp += 2;
            }
        }

        public override void PrintEmptyShape()
        {
            int temp = upperBase;
            for (int i = 0; i < height; i++)
            {
                for (int k = height - i; k > 1; k--)
                    Console.Write("  ");
                for (int j = 0; j < temp; j++)
                {
                    if (IsOutline(i, j, temp, height))
                        Console.Write($"{representativeChar} ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
                temp += 2;
            }
        }

        public override void Update(bool full, char representativeChar, int height, int upperBase)
        {
            this.isFull = full;
            this.representativeChar = representativeChar;
            this.height = height;
            this.upperBase = upperBase;
        }

        public override void UpdateWidth(int width)
        {
            this.upperBase = width;
        }
    }
}
