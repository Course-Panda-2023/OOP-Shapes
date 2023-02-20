
using System;
using Shapes;

Rectangle r1 = new Rectangle(false, '$', 3, 4);
//r1.PrintShape();
//Console.WriteLine();
Square s1 = new Square(true, '*', 5);
//s1.PrintShape();
//Console.WriteLine();
Rhombus rh1 = new Rhombus(false, '!', 7);
//rh1.PrintShape();
//Console.WriteLine();
Parallelogram t1 = new Parallelogram(true, '%', 4, 3);
//t1.PrintShape();
//Console.WriteLine();
Triangle tr1 = new Triangle(false, '&', 8);
//tr1.PrintShape();
//Console.WriteLine();
Trapezoid tra1 = new Trapezoid(true, '#', 6, 9);
//tra1.PrintShape();
List<Shape> demoShapes = new List<Shape>();
demoShapes.Add(tr1);
demoShapes.Add(r1);
demoShapes.Add(s1);
demoShapes.Add(t1);
demoShapes.Add(rh1);
demoShapes.Add(tra1);

List<Shape> shapes = new List<Shape>();

static Shape CreateCurrentShape(List<Shape> demoShapes)
{
    Shape shape1 = GetShape(demoShapes);
    shape1 = UpdatedShape(shape1);
    return shape1;
}
static Shape UpdatedShape(Shape shape1)
{
    Console.WriteLine("Enter '1' if the shape is filled and '0' if not.");
    bool fill = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Enter the character you want to use in the printing.");
    string temp = Console.ReadLine();
    char representativeChar = GetRepChar(temp);
    Console.WriteLine("Enter the length of the side of the shape.");
    int side = Convert.ToInt32(Console.ReadLine());
    int width = 0;
    if (shape1 is Rectangle || shape1 is Trapezoid || shape1 is Parallelogram)
    {
        Console.WriteLine("Enter the length of the width of the shape.");
        width = Convert.ToInt32(Console.ReadLine());
    }
    shape1.Update(fill, representativeChar, side, width);

    return shape1;
}

static void AddShape(List<Shape> demoShapes, ref List<Shape> shapes)
{
    Shape shape = CreateCurrentShape(demoShapes);
    shapes.Add(shape);
}

static void UpdateShape(ref List<Shape> shapes)
{
    Shape shape = GetShape(shapes);
    Console.WriteLine("Now enter the parameters you want to update.");
    shape = UpdatedShape(shape);
}

static Shape GetShape(List<Shape> shapes)
{
    int index = 1;
    Console.WriteLine("Choose the index (from the list) of the shape you want to update:");
    foreach (Shape s in shapes)
    {
        Console.WriteLine(index + " - " + s.GetType().Name);
        index++;
    }
    index = Convert.ToInt32(Console.ReadLine());
    return shapes[index - 1];
}

static char GetRepChar(string s)
{
    char representativeChar;
    if (s == string.Empty)
    {
        representativeChar = '#';
    }
    else
    {
        representativeChar = Convert.ToChar(s);
    }
    return representativeChar;
}

int input = 0;
while(input != -1) 
{
    Console.WriteLine();
    Console.WriteLine("Enter '1' to create a new shape.");
    Console.WriteLine("Enter '2' to update a shapes parameters.");
    Console.WriteLine("Enter '3' to remove an existing shape.");
    Console.WriteLine("Enter '4' to print a shape.");
    Console.WriteLine("Enter '-1' to stop the running of the program.");

    input = Convert.ToInt32(Console.ReadLine());
    if (input == -1)
        break;

    switch (input)
    {
        case 1:
            AddShape(demoShapes, ref shapes);
            Console.WriteLine();
            break;

        case 2:
            UpdateShape(ref shapes);
            Console.WriteLine();
            break;

        case 3:
            Console.WriteLine("Enter the index of the shape you want to remove.");
            Shape shape = GetShape(shapes);
            shapes.Remove(shape);
            Console.WriteLine();
            break;

        case 4:
            Console.WriteLine("Enter the index of the shape you want to print.");
            Shape shape2 = GetShape(shapes);
            shape2.PrintShape();
            Console.WriteLine();
            break;

        default:
            Console.WriteLine("The input you entered is wrong.");
            break;
    }
}


