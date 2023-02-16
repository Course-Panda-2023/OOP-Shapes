using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// class represents a trapezium shape
    /// </summary>
    internal class Trapezium : Shape
    {
        private const int Height = 100;
        private readonly int _base1;
        private readonly int _base2;

        private bool isFilled = true;

        public bool IsFilled
        {
            get { return isFilled; }
            set { isFilled = value; }
        }

        /// <summary>
        /// constructs a trapezium
        /// </summary>
        /// <param name="base1">an upper base</param>
        /// <param name="base2">another base</param>
        public Trapezium(int base1, int base2)
        {
            _base1 = base1;
            _base2 = base2;
        }

        private void DrawFilled()
        {
            int widthDiff = _base2 - _base1;
            int currentWidth = _base1;

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < currentWidth; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
                currentWidth += (int)Math.Ceiling((double)widthDiff / Height);
            }

            Console.WriteLine();
        }


        public void DrawUnfilled()
        {
            int widthDiff = _base2 - _base1;
            int currentWidth = _base1;

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < currentWidth; j++)
                {
                    if (i == 0 || i == Height - 1 || j == 0 || j == currentWidth - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
                currentWidth += (int)Math.Ceiling((double)widthDiff / Height);
            }

            Console.WriteLine();
        }

        public void Draw()
        {
            Console.WriteLine("Trapezium");
            if (isFilled)
            {
                DrawFilled();
                return;
            }
            DrawUnfilled();
        }

        public void SetIsFilled(bool isFilled)
        {
            this.isFilled = isFilled;
        }

        public bool GetIsFilled()
        {
            return isFilled;
        }
    }
}
