namespace Shapes
{
    public class Trapezoid : Shape
    {
        private int BaseOne;
        private int BaseTwo;
        private int Height;

        public Trapezoid(bool isFilled, char sign, int baseOne, int baseTwo, int height) : base(isFilled, sign)
        {
            this.BaseOne = baseOne;
            this.BaseTwo = baseTwo;
            this.Height = height;
        }

        protected override void PrintFilled()
        {
            for (int i = 0; i < this.Height; i++)
            {
                for (int j = 0; j < this.BaseTwo - (i + this.BaseOne); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + this.BaseOne; k++)
                {
                    Console.Write($"{this.Sign}");
                }
                Console.WriteLine();
            }
        }

        protected override void PrintNonFilled()
        {
            for (int i = 0; i < this.Height; i++)
            {
                for (int j = 0; j < this.BaseTwo - (i + this.BaseOne); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + this.BaseOne; k++)
                {
                    if (i == Height - 1 || k == 0 || k == i + this.BaseOne - 1)
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

        public override void Update(Dictionary<string, int> parameters, bool isFilled, char sign)
        {
            this.Height = parameters["Height"];
            this.IsFilled = isFilled;
            this.Sign = sign;
            this.BaseOne = parameters["BaseOne"];
            this.BaseTwo = parameters["BaseTwo"];
        }
    }
}
