using System;
public class Program
{
    public static void Main(string[] args)
    {
        ShapesManager manager = new ShapesManager();

        while (true)
        {
            manager.PrintAllShapes();
            Console.WriteLine("what do you want to do? \n 1. create new shape \n 2. update shape details \n 3. delete existing shape \n 4. print shape");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("which shape do you want? (square, rectangle, triangle, circle, rhombus, trapeze)");
                    Shape s;
                    string shape = Console.ReadLine();
                    switch(shape)
                    {
                        case "square":
                            Console.WriteLine("write size: ");
                            int sizeI = int.Parse(Console.ReadLine());
                            Console.WriteLine("write new char: ");
                            char squareFill = char.Parse(Console.ReadLine());
                            s = new Square(sizeI, squareFill);
                            Console.WriteLine("this is your shape: ");
                            s.Draw(true);
                            manager.AddShape(s);
                            break;
                        case "rectangle":
                            Console.WriteLine("width: ");
                            int widthI = int.Parse(Console.ReadLine());
                            Console.WriteLine("height: ");
                            int heightI = int.Parse(Console.ReadLine());
                            Console.WriteLine("write new char: ");
                            char rectangleFill = char.Parse(Console.ReadLine());
                            s = new Rectangle(widthI, heightI, rectangleFill);
                            Console.WriteLine("this is your shape: ");
                            s.Draw(true);
                            manager.AddShape(s);
                            break;
                        case "circle":
                            Console.WriteLine("write radius: ");
                            int radiusI = int.Parse(Console.ReadLine());
                            Console.WriteLine("write new char: ");
                            char circleFill = char.Parse(Console.ReadLine());
                            s = new Circle(radiusI, circleFill);
                            Console.WriteLine("this is your shape: ");
                            s.Draw(true);
                            manager.AddShape(s);
                            break;
                        case "triangle":
                            Console.WriteLine("write height");
                            int heightIt = int.Parse(Console.ReadLine());
                            Console.WriteLine("write new char: ");
                            char triangleFill = char.Parse(Console.ReadLine());
                            s = new Triangle(heightIt, triangleFill);
                            Console.WriteLine("this is your shape: ");
                            s.Draw(true);
                            manager.AddShape(s);
                            break;
                        case "rhombus":
                            Console.WriteLine("write size");
                            int sizeIr = int.Parse(Console.ReadLine());
                            Console.WriteLine("write new char: ");
                            char rhombusFill = char.Parse(Console.ReadLine());
                            s = new Rhombus(sizeIr, rhombusFill);
                            Console.WriteLine("this is your shape: ");
                            s.Draw(true);
                            manager.AddShape(s);
                            break;
                        case "trapeze":
                            Console.WriteLine("write size");
                            int sizeIt = int.Parse(Console.ReadLine());
                            Console.WriteLine("write base size");
                            int baseT = int.Parse(Console.ReadLine());
                            Console.WriteLine("write new char: ");
                            char trapezeFill = char.Parse(Console.ReadLine());
                            s = new Trapeze(sizeIt, baseT, trapezeFill);
                            Console.WriteLine("this is your shape: ");
                            s.Draw(true);
                            manager.AddShape(s);
                            break;
                    }
                    break;
                case 2:
                    manager.PrintAllShapes();
                    Console.WriteLine("write id to edit: ");
                    int editShapeIndex = int.Parse(Console.ReadLine());
                    manager.ShapeList[editShapeIndex].ShapeEditPrompt();
                    break;
                case 3:
                    manager.PrintAllShapes();
                    Console.WriteLine("which shape do you want to delete?");
                    int deleteShape = int.Parse(Console.ReadLine());
                    manager.RemoveShape(manager.ShapeList[deleteShape]);
                    break;
                case 4:
                    Console.WriteLine("which shape do you want to print?");
                    manager.PrintAllShapes();
                    int printIndex = int.Parse(Console.ReadLine());
                    Console.WriteLine("fill in or not? (y/n)");
                    string fillIn = Console.ReadLine();
                    if (fillIn == "y") manager.ShapeList[printIndex].Draw(true);
                    else manager.ShapeList[printIndex].Draw(false);
                    break;
            }
        }
    }
}