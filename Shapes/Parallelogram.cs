namespace Shapes
{
    public class Parallelogram : Rhombus
    {
        protected int Height;
        protected int Width;

        public override void Update(Dictionary<string, int> parameters, bool isFilled, char sign)
        {
            this.Edge = parameters["Edge"];
            this.IsFilled = isFilled;
            this.Sign = sign;
            this.Height = parameters["Height"];
            this.Width = parameters["Width"];
        }
        public Parallelogram(bool isFilled, char sign, int height, int width, int edge) : base(edge, isFilled, sign)
        {
            this.Height = height;
            this.Width = width;
        }

        protected override void PrintFilled()
        {
            for (int heightIndex = 0; heightIndex < this.Height; heightIndex++)
            {
                for (int j = 0; j < heightIndex; j++)
                {
                    Console.Write(" ");
                }
                for (int widthIndex = 0; widthIndex < this.Width; widthIndex++)
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
                for (int j = 0; j < this.Height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < this.Width; k++)
                {
                    if (i == 0 || i == this.Height - 1 || k == 0 || k == this.Width - 1)
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
