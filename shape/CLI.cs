namespace Shapes.shape;

public class CLI
{
    private Dictionary<String, Shape> shapes = new Dictionary<string, Shape>();

    public void CreateNewShape()
    {
        Console.WriteLine("Enter the name of the shape that you want to insert: ");
        string shapeName = Console.ReadLine();

        Console.WriteLine("Enter its type [Rectangle | Rhombus | Square | Trapeze | Triangular]");
        string shapeType = Console.ReadLine();

        while (!(new List<String> {"Rectangle", "Rhombus", "Square", "Trapeze", "Triangular"}).Contains(shapeType))
        {
            Console.WriteLine("Type needs to be one of [Rectangle | Rhombus | Square | Trapeze | Triangular]");
            shapeType = Console.ReadLine();
        }
        
        Console.WriteLine("Do you want to fill the shape when printing? [y|n]");
        string fillString = "";
        
        while (!(new List<String> {"y", "n"}).Contains(fillString))
        {
            Console.WriteLine("Enter [y|n]");
            fillString = Console.ReadLine();
        }
        
        Console.WriteLine("Enter the representing character");
        string representingChar = "";

        while (representingChar.Length != 1)
        {
            Console.WriteLine("Enter only one character");
            representingChar = Console.ReadLine();
        }
        
        char reprChar = Convert.ToChar(representingChar);

        bool fill = false;
        switch (fillString)
        {
            case "y":
                fill = true;
                break;
            case "n":
                fill = false;
                break;
        }

        Shape shape = new Rectangle(fill, reprChar, 10, 10);

        switch (shapeType)
        {
            case "Rectangle":
                shape = new Rectangle(fill, reprChar, 15, 10);
                break;
            case "Rhombus":
                shape = new Rhombus(fill, reprChar, 15, 15);
                break;
            case "Square":
                shape = new Square(fill, reprChar, 5, 10);
                break;
            case "Trapeze":
                shape = new Trapeze(fill, reprChar, 10, 30);
                break;
            case "Triangular":
                shape = new Triangular(fill, reprChar, 10, 10);
                break;
        }

        shapes[shapeName] = shape;
    }

    public void DeleteShape()
    {
        Console.WriteLine("Enter the name of the shape that you want to delete: ");
        string shapeName = Console.ReadLine();

        if (! shapes.ContainsKey(shapeName))
        {
            Console.WriteLine($"There is no shape with the name {shapeName}");
            return;
        }
        
        // else:

        shapes.Remove(shapeName);
        Console.WriteLine($"Successfully removed the shape {shapeName}");
    }
    
    public void PrintShape()
    {
        Console.WriteLine("Enter the name of the shape that you want to print: ");
        string shapeName = Console.ReadLine();

        if (! shapes.ContainsKey(shapeName))
        {
            Console.WriteLine($"There is no shape with the name {shapeName}");
            return;
        }
        
        // else:
        
        Console.WriteLine($"Printing the shape {shapeName}");

        shapes[shapeName].Print();
    }

    public void Start()
    {
        int chose;
        while (true)
        {
            Console.WriteLine("Please enter your chose");
            Console.WriteLine("[1]: Add a shape");
            Console.WriteLine("[2]: Remove a shape");
            Console.WriteLine("[3]: Print a shape");

            try
            {
                chose = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.FormatException e)
            {
                continue;
            }
            
            if ((chose < 1) || (chose > 3))
            {
                continue;
            }

            switch (chose)
            {
                case 1: 
                    this.CreateNewShape();
                    break;
                case 2:
                    this.DeleteShape();
                    break;
                case 3:
                    this.PrintShape();
                    break;
            }
        }
    }
}