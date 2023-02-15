using Shapes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

ShapesModel shapeModel = new ShapesModel();
ShapeFactory shapeFactory = new ShapeFactory(); 
Dictionary<string, Action> Operations = new Dictionary<string, Action>()
{
    { "Create", CreateNewShape },
    { "Update", UpdateShape },
    { "Delete", DeleteShape },
    { "PrintAll", PrintShape },
    { "CreateAndPrintAll", AddAndPrintAll },
    {"Exit", Exit }
};

string MostCloseOption(string option)
{
   //Operations.Keys
   return ""
}

void Exit()
{
    System.Environment.Exit(1);
}
void AddAndPrintAll()
{
    foreach(string shape in shapeFactory.shapesNames)
    {
        shapeModel.Add(shapeFactory.GetShape(shape));
    }
    shapeModel.DrawAll();
}

Shape GetSomeValidShape()
{
    string userInput = "";
    Console.Write("Enter shape name i.e.: ");
    Console.Write("[");
    foreach (string shapeName in shapeFactory.shapesNames)
    {
        Console.Write(shapeName + " ");
    }
    Console.Write("]");
    Console.WriteLine();
    Shape shape;
    do
    {
        Console.Write("># ");
        userInput = Console.ReadLine();
        shape = shapeFactory.GetShape(userInput);
    } while (string.IsNullOrEmpty(userInput) || shape is null);

    return shape;
}

/// <summary>
/// util function that check if two string are equal ignoring the case
/// </summary>
/// <param name="s1">a string</param>
/// <param name="s2">another string</param>
/// <returns></returns>
bool IsEqualIgnoreCases(string s1, HashSet<string> s2)
{
    foreach (string s in s2)
    {
        if (string.Equals(s1, s, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
    }
    return false;
}


bool IsFilledShape()
{
    string userInput;
    do
    {
        Console.WriteLine("Is filled shape [ Yes, other keys to No ]");

        Console.Write("># ");
        userInput = Console.ReadLine();
    } while (string.IsNullOrEmpty(userInput));

    HashSet<string> s = new HashSet<string>()
    {
        "Yes", "Y", "Yeah", "YY", "YE"
    };
    return IsEqualIgnoreCases(userInput, s);
}

void CreateNewShape()
{
    bool isFilledShape = IsFilledShape();
    Shape shape = GetSomeValidShape();
    Console.WriteLine("Created the new shape");
    shape.SetIsFilled(isFilledShape);
    shapeModel.Add(shape);
    shape.Draw();
}

int GetInputNumber()
{
    int userInput;
    string input;
    do
    {
        Console.WriteLine("Enter a number with the certain range");
        Console.Write("># ");
        input = Console.ReadLine();
    } while (!Int32.TryParse(input, out userInput));
    return userInput;
}

void UpdateShape() 
{
    Console.WriteLine("Update");
    if (shapeModel.GetLength() == 0)
    {
        Console.WriteLine("Not Yet! There are no shapes created!");
        return;
    }
    Console.WriteLine($"Enter an idex from 0 to {shapeModel.GetLength() - 1}");
    int input = GetInputNumber();
    shapeModel.Update(input);
    Console.WriteLine("Updated successfully!!!");
}

void DeleteShape() 
{
    Console.WriteLine("Delete");
    Shape shape = GetSomeValidShape();

    shapeModel.Delete(shape);
    Console.WriteLine("Deleted successfully!!!");
}

void PrintShape() 
{
    Console.WriteLine("Print all created shapes");
    if (shapeModel is null) return;
    shapeModel.DrawAll();    
}

void PrintAllKeys()
{
    foreach (var key in Operations.Keys)
    {
        Console.Write($"{key} ");
    }
    Console.WriteLine();
}

string TryParseAndInput()
{
    string userInput = "";
    while (string.IsNullOrEmpty(userInput) || !Operations.ContainsKey(userInput))
    {
        Console.Write("Please Enter one of: ");
        PrintAllKeys();
        Console.Write("># ");
        userInput = Console.ReadLine();
    }
    return userInput;
}

Console.WriteLine("Shapes factory command line");

bool isAlive = true;

while (isAlive)
{
    string pressedKey = TryParseAndInput();

    Operations[pressedKey].Invoke();

    Console.WriteLine();
    Console.WriteLine();
}
