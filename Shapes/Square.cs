using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        protected int side;

        public Square(bool isFull, char representativeChar, int side) : base(isFull, representativeChar)
        {
            this.side = side;
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
                for (int j = 0; j < side; j++)
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
                for (int j = 0; j < side; j++)
                {
                    if (IsOutline(i, j, side, side))
                        Console.Write($"{representativeChar} ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public override void Update(bool full, char representativeChar, int heigth, int width)
        {
            this.isFull = full;
            this.representativeChar = representativeChar;
            this.side = heigth;
        }

        public override void Updateheigth(int heigth)
        {
            this.side = heigth;
        }

        public override void UpdateWidth(int width)
        {
            throw new NotImplementedException();
        }
    }
}
