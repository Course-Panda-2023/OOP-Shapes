public class Circle : Shape
{
    public Circle(int Radius, char fill) : base(Radius, fill)
    {

    }

    public override void Draw(bool isFilled)
    {
        int diameter = this.Size * 2;
        int centerX = this.Size;
        int centerY = this.Size;

        for (int y = 0; y <= diameter; y++)
        {
            for (int x = 0; x <= diameter; x++)
            {
                double distance = Math.Sqrt((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY));
                if (distance > this.Size - 0.5 && distance < this.Size + 0.5)
                {
                    Console.Write(this.Fill);
                }
                else if (isFilled && distance <= this.Size)
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
        Console.Write($"Circle {this.Fill}. Radius: {this.Size}");
    }

    public override void ShapeEditPrompt()
    {
        Console.WriteLine("write radius");
        int prompt = int.Parse(Console.ReadLine());
        this.Size = prompt;
        Console.WriteLine("write new char: ");
        char cPrompt = char.Parse(Console.ReadLine());
        this.Fill = cPrompt;
        Console.WriteLine("your new shape: ");
        Draw(true);
    }
}
