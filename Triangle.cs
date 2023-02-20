
class Triangle : Shape
{
    int EdgeLength;
    public Triangle(bool FillShape, char Char, int EdgeLength) : base(FillShape, Char)
    {
        this.EdgeLength = EdgeLength;
    }

    public override void PrintShape()
    {
        for (int i=0; i<this.EdgeLength; i++)
        {
            for (int j = 0; j < this.EdgeLength*2-1; j++)
            {
                if ((this.FillShape && j >= this.EdgeLength-1-i && j <= this.EdgeLength-1+i) // fill
                    || (i < this.EdgeLength-1 && j == this.EdgeLength-1-i) // left edge
                    || (i < this.EdgeLength-1 && j == this.EdgeLength-1+i) // right edge
                    || (i == this.EdgeLength-1) // bottom leg
                    )
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
        return $"Triangle (Fill: {this.FillShape}, Char: {this.Char}, Edge length: {this.EdgeLength})";
    }
    
}