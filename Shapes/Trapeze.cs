public class Trapeze : Shape
{
    public int BaseSize;
    public Trapeze(int size, int baseSize, char fill) : base(size, fill)
    {
        this.BaseSize = baseSize;
    }

    public override void Draw(bool isFilled)
    {
        for (int i = 1; i <= this.Size; i++)
        {
            int numSpaces = (this.Size - i) + (this.BaseSize - this.Size);

            for (int j = 1; j <= numSpaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= this.Size + (i - 1) * 2; j++)
            {
                if (i == 1 || i == this.Size || j == 1 || j == this.Size + (i - 1) * 2)
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
        Console.Write($"Trapeze {this.Fill}. Size: {this.Size}, Base Size: {this.BaseSize}");
    }

    public override void ShapeEditPrompt()
    {
        Console.WriteLine("write size");
        int prompt1 = int.Parse(Console.ReadLine());
        Console.WriteLine("write base");
        int prompt2 = int.Parse(Console.ReadLine());
        this.Size = prompt1;
        this.BaseSize = prompt2;
        Console.WriteLine("write new char: ");
        char cPrompt = char.Parse(Console.ReadLine());
        this.Fill = cPrompt;
        Console.WriteLine("your new shape: ");
        Draw(true);
    }
}
