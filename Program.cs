using ShapesExercise;

List<Shape> shapesList = new List<Shape>();
Console.WriteLine("Enter 1. to create a new Shape");
Console.WriteLine("Enter 2. to update a Shape");
Console.WriteLine("Enter 3. to remove a Shape");
Console.WriteLine("Enter 4. to print a Shape");
int inputNumber = Convert.ToInt32(Console.ReadLine());
while (inputNumber != -1)
{
    switch (inputNumber)
    {
        case 1:
            Console.WriteLine("Enter 1. to create a Square");
            Console.WriteLine("Enter 2. to create a Rectangle");
            Console.WriteLine("Enter 3. to create a Rhombus");
            Console.WriteLine("Enter 4. to create a Trapeze");
            Console.WriteLine("Enter 5. to create a Triangle");
            int shapeChoice = Convert.ToInt32(Console.ReadLine());
            switch (shapeChoice)
            {
                case 1:
                    Console.WriteLine("Enter edge length");
                    int edgeSqaure = Convert.ToInt32(Console.ReadLine());
                    Shape squareShape = new Square(edgeSqaure);
                    shapesList.Add(squareShape);
                    break;
                case 2:
                    Console.WriteLine("Enter first and second edges lengths");
                    int firstEdgeRect = Convert.ToInt32(Console.ReadLine());
                    int secondEdgeRect = Convert.ToInt32(Console.ReadLine());
                    Shape rectangleShape = new Rectangle(firstEdgeRect, secondEdgeRect);
                    shapesList.Add(rectangleShape);
                    break;
                case 3:
                    Console.WriteLine("Enter edge length");
                    int edgeRhombus = Convert.ToInt32(Console.ReadLine());
                    Shape rhombusShape = new Rhombus(edgeRhombus);
                    shapesList.Add(rhombusShape);
                    break;
                case 4:
                    Console.WriteLine("Enter base length and trapeze height");
                    int tbase = Convert.ToInt32(Console.ReadLine());
                    int height = Convert.ToInt32(Console.ReadLine());
                    Shape trapezeShape = new Trapeze(tbase, height);
                    shapesList.Add(trapezeShape);
                    break;
                case 5:
                    Console.WriteLine("Enter edge length");
                    int edgeTriangle = Convert.ToInt32(Console.ReadLine());
                    Shape triangleShape = new Triangle(edgeTriangle);
                    shapesList.Add(triangleShape);
                    break;
                default:
                    Console.WriteLine("Cant read " + shapeChoice);
                    continue;
            }
            break;
        case 2:
            Helper.printList(shapesList);
            Console.WriteLine("Choose a shape to update");
            int updateShape = Convert.ToInt32(Console.ReadLine());
            switch (shapesList[updateShape - 1].GetType().Name)
            {
                case "Square":
                    Console.WriteLine("Enter Square new edge length");
                    int squareNewEdge = Convert.ToInt32(Console.ReadLine());
                    Shape newSquare = new Square(squareNewEdge);
                    shapesList[updateShape - 1] = newSquare;
                    break;
                case "Rectangle":
                    Console.WriteLine("Enter Rectangle new first and second edges lengths");
                    int rectNewFirstEdge = Convert.ToInt32(Console.ReadLine());
                    int rectNewSecondEdge = Convert.ToInt32(Console.ReadLine());
                    Shape newRect = new Rectangle(rectNewFirstEdge, rectNewSecondEdge);
                    shapesList[updateShape - 1] = newRect;
                    break;
                case "Rhombus":
                    Console.WriteLine("Enter Rhombus new edge length");
                    int rhombusNewEdge = Convert.ToInt32(Console.ReadLine());
                    Shape newRhombus = new Square(rhombusNewEdge);
                    shapesList[updateShape - 1] = newRhombus;
                    break;
                case "Trapeze":
                    Console.WriteLine("Enter Trapeze new upper base length");
                    int trapezeNewUpperBase = Convert.ToInt32(Console.ReadLine());
                    Shape newTrapeze = new Square(trapezeNewUpperBase);
                    shapesList[updateShape - 1] = newTrapeze;
                    break;
                case "Triangle":
                    Console.WriteLine("Enter Triangle new edge length");
                    int triangleNewEdge = Convert.ToInt32(Console.ReadLine());
                    Shape newTriangle = new Square(triangleNewEdge);
                    shapesList[updateShape - 1] = newTriangle;
                    break;
                default:
                    continue;
            }
            break;
        case 3:
            Helper.printList(shapesList);
            Console.WriteLine("Enter number to remove this shape");
            int removeShape = Convert.ToInt32(Console.ReadLine());
            shapesList.RemoveAt(removeShape - 1);
            break;
        case 4:
            Helper.printList(shapesList);
            int printShape = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 to print filled shape,  Enter 2 to print hollow shape");
            int fillOrHollow = Convert.ToInt32(Console.ReadLine());
            if (fillOrHollow == 1)
                shapesList[printShape - 1].PrintShapeFill();
            else
                shapesList[printShape - 1].PrintShape();
            break;
        default:
            break;
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Enter 1. to create a new Shape");
    Console.WriteLine("Enter 2. to update a Shape");
    Console.WriteLine("Enter 3. to remove a Shape");
    Console.WriteLine("Enter 4. to print a Shape");
    Console.WriteLine("Enter -1. to EXIT");
    inputNumber = Convert.ToInt32(Console.ReadLine());
}