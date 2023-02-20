public class Rectangle : Shape
{
    private int Width, Height;

    public Rectangle(int width, int height, char fill) : base(width, fill)
    {
        this.Width = width;
        this.Height = height;
    }
    
    public override void Draw(bool isFilled)
    {
        for (int i = 1; i <= this.Height; i++)
        {
            for (int j = 1; j <= this.Width; j++)
            {
                if (i == 1 || i == this.Height || j == 1 || j == this.Width)
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
        Console.Write($"Rectangle {this.Fill}. Width: {this.Width}, Height: {this.Height}");
    }

    public override void ShapeEditPrompt()
    {
        Console.WriteLine("write width");
        int prompt1 = int.Parse(Console.ReadLine());
        Console.WriteLine("write height");
        int prompt2 = int.Parse(Console.ReadLine());
        this.Width = prompt1;
        this.Height = prompt2;
        Console.WriteLine("write new char: ");
        char cPrompt = char.Parse(Console.ReadLine());
        this.Fill = cPrompt;
        Console.WriteLine("your new shape: ");
        Draw(true);
    }
}
