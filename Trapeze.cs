
class Trapeze : Shape
{
    int TopBase;
    int Height;
    public Trapeze(bool FillShape, char Char, int TopBase, int Height) : base(FillShape, Char)
    {
        this.TopBase = TopBase;
        this.Height = Height;
    }

    public override void PrintShape()
    {
        for (int i=0; i<this.Height; i++)
        {
            for (int j = 0; j <= 2*(this.Height-1)+this.TopBase; j++)
            {
                if (!this.FillShape) // hollow
                {
                    if ((i == 0 && j >= this.Height-1 && j <= this.TopBase + this.Height-1) // top base
                        || (i == this.Height-1) // bottom base
                        || (j == this.Height-1-i) // left wing
                        || (j == this.Height-1 + this.TopBase + i)) // right wing
                        Console.Write(this.Char);
                    else
                        Console.Write(" ");
                }
                else // fill
                {
                    if (j >= this.Height-1-i && j <= this.Height-1 + this.TopBase + i) 
                        Console.Write(this.Char);
                    else
                        Console.Write(" ");
                }
                
            }
            Console.WriteLine("");
        }
    }

    public override void UpdateShape()
    {
        Console.WriteLine("Choose what to update:");
        Console.WriteLine("1. Fill shape");
        Console.WriteLine("2. Char");
        Console.WriteLine("3. Top base");
        Console.WriteLine("4. Height");

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
                Console.WriteLine("Enter top base");
                this.TopBase = Convert.ToInt32(Console.ReadLine());
                break;   
            case 4:
                Console.WriteLine("Enter height");
                this.Height = Convert.ToInt32(Console.ReadLine());
                break;
                
        }
    }

    public override string ToString()
    {
        return $"Trapeze (Fill: {this.FillShape}, Char: {this.Char}, Top base: {this.TopBase}, Height: {this.Height})";
    }

}