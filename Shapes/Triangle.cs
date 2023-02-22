namespace Shapes
{
    internal class Triangle : Shape
    {
        private const int Height = 7;

        private bool isFilled = false;

        public bool IsFilled
        {
            get { return isFilled; }
            set { isFilled = value; }
        }

        public void Draw()
        {
            Console.WriteLine("Triangle");
            for (int i = 0; i < Height; ++i)
            {
                if (i != 0)
                {
                    Console.Write("#");
                }
                if (i == Height - 1)
                {
                    for (int j = 0; j < i; ++j)
                    {
                        Console.Write("#");
                    }
                }
                else
                {
                    for (int j = 1; j < i; ++j)
                    {
                        Console.Write(isFilled ? "#" : " ");
                    }
                    Console.Write("#");
                    Console.WriteLine();
                }
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
