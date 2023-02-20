using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Trapezoid : Triangle
    {
        protected int upperBase;

        public Trapezoid(bool full, char representativeChar, int side, int upperBase) : base(full, representativeChar, side)
        {
            this.upperBase = upperBase;
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
            int temp = upperBase;
            for (int i = 0; i < height; i++)
            {
                for (int k = height - i; k > 1; k--)
                    Console.Write("  ");
                for (int j = 0; j < temp; j++)
                    Console.Write(representativeChar + " ");
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
                    if (i == 0 || j == 0 || j == temp - 1 || i == height - 1)
                        Console.Write(representativeChar + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
                temp += 2;
            }
        }

        public override void Update(bool full, char representativeChar, int height, int upperBase)
        {
            this.full = full;
            this.representativeChar = representativeChar;
            this.height = height;
            this.upperBase = upperBase;
        }
    }
}
