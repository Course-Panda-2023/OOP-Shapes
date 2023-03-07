namespace Shapes
{
    public class Triangle : Shape
    {
        private int Height;

        public Triangle(int height, bool isFilled, char sign) : base(isFilled, sign)
        {
            this.Height = height;
        }

        protected override void PrintFilled()
        {
            int baseLength = this.Height * 2 - 1;

            for (int heightIndex = 0; heightIndex < this.Height; heightIndex++)
            {
                for (int baseIndex = 0; baseIndex < baseLength; baseIndex++)
                {
                    if (baseIndex >= (baseLength - (2 * heightIndex + 1)) / 2 && baseIndex <= (baseLength + (2 * heightIndex + 1)) / 2)
                    {
                        Console.Write($"{Sign} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        protected override void PrintNonFilled()
        {
            int baseLength = this.Height * 2 - 1;

            for (int heightIndex = 0; heightIndex < this.Height; heightIndex++)
            {
                for (int baseIndex = 0; baseIndex < baseLength; baseIndex++)
                {
                    if (heightIndex == this.Height - 1 || baseIndex == (baseLength - (2 * heightIndex + 1)) / 2 || baseIndex == (baseLength + (2 * heightIndex + 1)) / 2)
                    {
                        Console.Write($"{Sign} ");
                    }
                    else
                    {
                        Console.Write("  ");
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
        }
    }
}
