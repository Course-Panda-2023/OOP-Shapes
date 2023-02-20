class CLI
{
    private List<Shape> shapes = new List<Shape>();
    private void MakeShape()
    {
        Console.WriteLine("what shape");
        Console.WriteLine("1. square");
        Console.WriteLine("2. rectangle");
        Console.WriteLine("3. rhombus");
        Console.WriteLine("4. triangle");
        Console.WriteLine("5. trapezoid");
        var action = Console.ReadLine();
        if (action == "1") { shapes.Add(MakeSquare()); }
        else if (action == "2") { shapes.Add(MakeRectangle()); }
        else if (action == "3") { shapes.Add(MakeRhombus()); }
        else if (action == "4") { shapes.Add(MakeTriangle()); }
        else if (action == "5") { shapes.Add(MakeTrapezoid()); }
    }
    private bool MakeFull()
    {
        Console.WriteLine("full or empty?");
        Console.WriteLine("1. full");
        Console.WriteLine("2. empty");
        var action = Console.ReadLine();
        if(action == "1") { return true; }
        return false;
    }
    
    private char ReadId()
    {
        Console.WriteLine("Write Sign");
        var id  = Console.ReadLine();
        if (id is null)
        {
            return '#';
        }
        return id[0];
    }
    
    private Square MakeSquare()
    {
        Console.WriteLine("enter width");
        int width = Convert.ToInt32(Console.ReadLine());
        return new Square(width, MakeFull(), ReadId());
    }
    private Rectangle MakeRectangle()
    {
        Console.WriteLine("enter width");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter hight");
        int hight = Convert.ToInt32(Console.ReadLine());
        return new Rectangle(hight, width, MakeFull(), ReadId());
    }
    private Rhombus MakeRhombus()
    {
        Console.WriteLine("enter edgeLength");
        int edgeLength = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter hight");
        int hight = Convert.ToInt32(Console.ReadLine());
        return new Rhombus(edgeLength, hight, MakeFull(), ReadId());
    }
    private Triangle MakeTriangle()
    {
        Console.WriteLine("enter hight");
        int hight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter largeBaseLeftbulge");
        int largeBaseLeftbulge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter largeBaseRightbulge");
        int largeBaseRightbulge = Convert.ToInt32(Console.ReadLine());
        return new Triangle(hight, largeBaseLeftbulge, largeBaseRightbulge, MakeFull(), ReadId());
    }
    private Trapezoid MakeTrapezoid()
    {
        Console.WriteLine("enter hight");
        int hight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter smallBase"); 
        int smallBase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter largeBaseLeftbulge");
        int largeBaseLeftbulge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter largeBaseRightbulge");
        int largeBaseRightbulge = Convert.ToInt32(Console.ReadLine());
        return new Trapezoid(hight, smallBase, largeBaseLeftbulge, largeBaseRightbulge, MakeFull(), ReadId());
    }
    private void EditShape()
    {
        DeleteShape();
        Console.WriteLine("now make it again but diffrently");
        MakeShape();

    }
    private void DeleteShape()
    {
        shapes.Remove(ChooseShape());
    }
    private void PrintShape()
    {
        ChooseShape().Print();
    }
    private Shape ChooseShape()
    {
        Console.WriteLine("which shape?");
        if (shapes.Count > 0)
        {
            for (int i = 0; i < this.shapes.Count; i++)
            {
                Console.WriteLine($"{i}.{shapes[i].GetType()}");
            }
        }
        int action = Convert.ToInt32(Console.ReadLine());
        return shapes[action];
    }
    public void Run()
    {
        while(true)
        {
            Console.WriteLine("What Do You Want To Do?");
            Console.WriteLine("1. Make a new shape");
            Console.WriteLine("2. Edit an existing shape");
            Console.WriteLine("3. Delete an existing shape");
            Console.WriteLine("4. Print an existing shape");
            var action = Console.ReadLine();
            if (action == "1") { MakeShape(); }
            else if (action == "2") { EditShape(); } 
            else if (action == "3") { DeleteShape(); }
            else if (action == "4") { PrintShape(); }
            else { Console.WriteLine("error"); }
        }
    }
}


    