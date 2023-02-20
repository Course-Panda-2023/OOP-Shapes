
class Rectangle : Shape
{
    int Height;
    int Width;
    public Rectangle(bool FillShape, char Char, int Height, int Width) : base(FillShape, Char)
    {
        this.Height = Height;
        this.Width = Width;
    }

    public override void PrintShape()
    {
        for (int i=0; i<this.Height; i++)
        {
            for (int j = 0; j < this.Width; j++)
            {
                if (this.FillShape || i == 0 || i == this.Height-1 || j == 0 || j == this.Width-1)
                    Console.Write(this.Char);
                else
                    Console.Write(" ");

            }
            Console.WriteLine("");
        }
    }

    public override void UpdateShape()
    {
        Console.WriteLine("Choose what to update:");
        Console.WriteLine("1. Fill shape");
        Console.WriteLine("2. Char");
        Console.WriteLine("3. Height");
        Console.WriteLine("4. Width");

        int action = Convert.ToInt32(Console.ReadLine());
        switch (action)
        {
            case 1:
                Console.WriteLine("Fill shape when printing it? (y/n)");          
                this.FillShape = Console.ReadLine() == "y" ? true: false;
                break;
            case 2:
                Console.WriteLine("Insert characterizing char");          
                try
                {
                    this.Char = Console.ReadLine()[0];
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("No char entered. Char unchanced.");
                }
                break;
            case 3:
                Console.WriteLine("Enter height");
                this.Height = Convert.ToInt32(Console.ReadLine());
                break;
            case 4:
                Console.WriteLine("Enter width");
                this.Width = Convert.ToInt32(Console.ReadLine());
                break;   
        }
    }

    public override string ToString()
    {
        return $"Rectangle (Fill: {this.FillShape}, Char: {this.Char}, Width: {this.Width}, Height {this.Width})";
    }

}