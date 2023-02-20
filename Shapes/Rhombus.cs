namespace Shapes
{
    public class Rhombus : Square
    {
        public Rhombus(int edge, bool isFilled, char sign) : base(edge, isFilled, sign)
        {
        }

        protected override void PrintFilled()
        {
            for (int i = 0; i < this.Edge; i++)
            {
                for (int j = 0; j < this.Edge - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = this.Edge - 2; i >= 0; i--)
            {
                for (int j = 0; j < this.Edge - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        protected override void PrintNonFilled()
        {
            for (int i = 0; i < this.Edge; i++)
            {
                for (int j = 0; j < this.Edge - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    if (i == 0 || i == this.Edge - 1 || k == 0 || k == 2 * i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = this.Edge - 2; i >= 0; i--)
            {
                for (int j = 0; j < this.Edge - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    if (i == 0 || i == this.Edge - 1 || k == 0 || k == 2 * i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

