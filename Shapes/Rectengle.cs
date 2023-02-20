namespace Shapes
{
    public class Rectengle : Square
    {
        private int SecondEdge;

        public Rectengle(int edge, bool isFilled, char sign, int secondEdge) : base(edge, isFilled, sign)
        {
            this.SecondEdge = secondEdge;
        }
        public override void Update(Dictionary<string, int> parameters, bool isFilled, char sign)
        {
            this.Edge = parameters["FirstEdge"];
            this.IsFilled = isFilled;
            this.Sign = sign;
            this.SecondEdge = parameters["SecondEdge"];
        }

        protected override void PrintFilled()
        {
            for (int i = 0; i < this.Edge; i++)
            {
                for (int j = 0; j < this.SecondEdge; j++)
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
                for (int j = 0; j < this.SecondEdge; j++)
                {
                    if (i == 0 || i == Edge - 1 || j == 0 || j == this.SecondEdge - 1)
                    {
                        Console.Write($"{this.Sign}");
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
