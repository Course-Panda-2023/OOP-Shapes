namespace Shapes
{
    public class Square : Shape
    {
        protected int Edge;

        public Square(int edge, bool isFilled, char sign) : base(isFilled, sign)
        {
            this.Edge = edge;
        }

        protected override void PrintNonFilled()
        {
            for (int i = 0; i < this.Edge; i++)
            {
                for (int j = 0; j < this.Edge; j++)
                {
                    if (i == 0 || i == this.Edge - 1 || j == 0 || j == this.Edge - 1)
                    {
                        Console.Write($"{this.Sign} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        protected override void PrintFilled()
        {
            for (int i = 0; i < this.Edge; i++)
            {
                for (int j = 0; j < this.Edge; j++)
                {
                    Console.Write($"{this.Sign} ");
                }
                Console.WriteLine();
            }
        }

        public override void Update(Dictionary<string, int> parameters, bool isFilled, char sign)
        {
            this.Edge = parameters["Edge"];
            this.IsFilled = isFilled;
            this.Sign = sign;
        }
    }
}
