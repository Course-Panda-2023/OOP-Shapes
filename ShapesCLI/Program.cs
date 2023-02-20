class Program
{
    public static void Main(string[] args)
    {
        CLI cli = new CLI();
        cli.Run();
    }
    public static void Main1(string[] args)
    {
        Rectangle rec = new (4, 5, false, '3');
        rec.Print();
        Square sq = new(4, false, 's');
        sq.Print();
        Rhombus rh1 = new (30, 7, false);
        rh1.Print();
        Rhombus rh2 = new(20, 15, false);
        rh2.Print();
        Rhombus rh3 = new(20, 15, true);
        rh3.Print();
        Trapezoid r1 = new(10, 0, 9, 15, false);
        r1.Print();
        Trapezoid r2 = new(10, 7, 9, 15, true);
        r2.Print();
        Trapezoid r3 = new(10, 10, 30, 5, false);
        r3.Print();
        Trapezoid r4 = new(10, 10, 30, 5, true);
        r4.Print();
        Trapezoid r5 = new(10, 10, 10, 35, false);
        r5.Print();
        for (int i = 0; i < 10; i++)
        {
            Trapezoid r6 = new(10, 5, 10, 3*i, false);
            r6.Print();
        }
        Trapezoid r7 = new(15, 15, 5, 6, false); r7.Print();
        
    }
}