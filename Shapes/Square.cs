using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// classs represents a square
    /// </summary>
    internal class Square : Shape
    {
        private const int Size = 3;

        private bool isFilled = true;

        public bool IsFilled
        {
            get { return isFilled; }
            set { isFilled = value; }
        }

        public void Draw()
        {
            Console.WriteLine("Square");

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == 0 || i == Size - 1)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        if (j == 0 || j == Size - 1)
                        {
                            Console.Write("# ");
                        }
                        else
                        {
                            Console.Write(isFilled ? "# " : "  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public bool GetIsFilled()
        {
            return isFilled;
        }

        public void SetIsFilled(bool isFilled)
        {
            this.isFilled = isFilled;
        }
    }
}
