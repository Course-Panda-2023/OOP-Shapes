namespace Shapes
{
    /// <summary>
    /// class reresents a rhombus
    /// </summary>
    internal class Rhombus : Shape
    {
        private int rhombusLength = 7;

        private bool isFilled = true;

        public bool IsFilled
        {
            get { return isFilled; }
            set { isFilled = value; }
        }

        public void Draw()
        {
            if (isFilled)
            {
                Console.WriteLine("Rhombus");
                int halfHeight = rhombusLength / 2;
                for (int i = 0; i < rhombusLength; i++)
                {
                    int spaces = Math.Abs(i - halfHeight);
                    int hashes = rhombusLength - spaces * 2;
                    Console.Write(new string(' ', spaces));
                    Console.Write(new string('#', hashes));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Rhombus");
                int halfHeight = rhombusLength / 2;
                Console.Write(new string(' ', halfHeight));
                Console.Write("#");
                Console.WriteLine();
                for (int i = 1; i < rhombusLength - 1; i++)
                {
                    int spaces = Math.Abs(i - halfHeight);
                    int hashes = rhombusLength - spaces * 2;
                    Console.Write(new string(' ', spaces));
                    Console.Write("#");
                    Console.Write(new string(' ', hashes - 2));
                    Console.Write("#");
                    Console.WriteLine();
                }
                Console.Write(new string(' ', halfHeight));
                Console.Write("#");
                Console.WriteLine();
            }
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
