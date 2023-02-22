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

        public Triangle(bool isFull, char representativeChar, int height) : base(isFull, representativeChar)
        {
            this.height = height;
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
            for (int i = 0; i < height; i++)
            {
                for (int j = height - i; j > 0; j--)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                    Console.Write($"{representativeChar} ");
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
                    if (IsOutline(i, j, i + 1, height))
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
            this.height = heigth;
        }

        public override void Updateheigth(int heigth)
        {
            this.height = heigth;
        }

        public override void UpdateWidth(int width)
        {
            throw new NotImplementedException();
        }
    }
}
