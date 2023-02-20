

class Square : Rectangle
{
    int EdgeLength;
    
    public Square(bool FillShape, char Char, int EdgeLength) : base(FillShape, Char, EdgeLength, EdgeLength)
    {
        this.EdgeLength = EdgeLength;
    }

    public override void UpdateShape()
    {
        Console.WriteLine("Choose what to update:");
        Console.WriteLine("1. Fill shape");
        Console.WriteLine("2. Char");
        Console.WriteLine("3. Edge length");

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
                Console.WriteLine("Enter edge length");
                this.EdgeLength = Convert.ToInt32(Console.ReadLine());
                break;
        }
    }

    public override string ToString()
    {
        return $"Square (Fill: {this.FillShape}, Char: {this.Char}, Edge length: {this.EdgeLength})";
    }
}