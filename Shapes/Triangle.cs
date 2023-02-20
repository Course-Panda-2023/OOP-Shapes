public class Triangle : Shape
{
    public Triangle(int size, char fill) : base(size, fill)
    {

    }

    public override void Draw(bool isFilled)
    {
        for (int i = 1; i <= this.Size; i++)
        {
            for (int j = 1; j <= this.Size - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                if (i == this.Size || j == 1 || j == 2 * i - 1)
                {
                    Console.Write(this.Fill);
                }
                else if (isFilled)
                {
                    Console.Write(this.Fill);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
    public override void PrintDetails()
    {
        Console.Write($"Triangle. Height: {this.Size}");
    }

    public override void ShapeEditPrompt()
    {
        Console.WriteLine("write height");
        int prompt = int.Parse(Console.ReadLine());
        this.Size = prompt;
        Console.WriteLine("your new shape: ");
        Draw(true);
    }
}
