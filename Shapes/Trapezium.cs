using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// class represents a trapezium shape
    /// </summary>
    internal class Trapezium : Shape
    {
        private const int Height = 9;
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

        public void Draw()
        {
            Console.WriteLine("Trapezium");
            if (isFilled)
            {

                int width = _base1 + _base2 - 1;

                for (int i = 1; i <= Height; i++)
                {
                    int numHashes = _base1 + (i - 1) * (_base2 - _base1) / (Height - 1);
                    int numSpaces = (width - numHashes) / 2;

                    for (int j = 1; j <= numSpaces; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= numHashes; j++)
                    {
                        Console.Write("#");
                    }

                    for (int j = 1; j <= numSpaces; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                int width = _base1 + _base2 - 1;


                for (int j = 1; j <= (width - _base1) / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= _base1; j++)
                {
                    Console.Write("#");
                }

                for (int j = 1; j <= (width - _base1) / 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
                for (int i = 2; i <= Height - 1; i++)
                {
                    int numHashes = _base1 + (i - 1) * (_base2 - _base1) / (Height - 1);
                    int numSpaces = (width - numHashes) / 2;

                    for (int j = 1; j <= numSpaces; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= numHashes; j++)
                    {
                        if (j == 1 || j == numHashes)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    for (int j = 1; j <= numSpaces; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }

                int numHashes1 = _base1 + (Height - 1) * (_base2 - _base1) / (Height - 1);
                int numSpaces1 = (width - numHashes1) / 2;

                for (int j = 1; j <= numSpaces1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= numHashes1; j++)
                {
                    Console.Write("#");
                }

                for (int j = 1; j <= numSpaces1; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
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
