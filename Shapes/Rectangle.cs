using Shapes;

namespace Shapes
{
    /// <summary>
    /// class reresents a rectangle
    /// </summary>
    internal class Rectangle : Shape
    {
        private const int Height = 7;
        private const int Width = 10;

        private bool isFilled = true;

        public bool IsFilled
        {
            get { return isFilled; }
            set { isFilled = value; }
        }

        public void Draw()
        {
            Console.WriteLine("Rectangle");
            for (int j = 1; j < Width; j++)
            {
                Console.Write("# ");
            }
            Console.WriteLine();
            for (int i = 1; i < Height - 2; i++)
            {
                Console.Write("# ");
                for (int j = 1; j < Width - 2; j++)
                {
                    Console.Write(isFilled ? "# " : "  ");
                }
                Console.Write("# ");
                Console.WriteLine();
            }
            for (int j = 1; j < Width; j++)
            {
                Console.Write("# ");
            }
            Console.WriteLine();
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
