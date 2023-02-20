public class Rhombus : Shape
{
    public Rhombus(int size, char fill) : base(size, fill)
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

            for (int j = 1; j <= this.Size; j++)
            {
                if (i == 1 || i == this.Size || j == 1 || j == this.Size)
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
        Console.Write($"Rhombus {this.Fill}. Size: {this.Size}");
    }

    public override void ShapeEditPrompt()
    {
        Console.WriteLine("write size");
        int prompt = int.Parse(Console.ReadLine());
        this.Size = prompt;
        Console.WriteLine("write new char: ");
        char cPrompt = char.Parse(Console.ReadLine());
        this.Fill = cPrompt;
        Console.WriteLine("your new shape: ");
        Draw(true);
    }
}
