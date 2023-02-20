// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.ComponentModel.DataAnnotations;

namespace app
{
    class Program
    {
        
        static void PrintShapeList(List<Shape> shapes)
        {
            Console.WriteLine("List of shapes:");
            int i = 1;
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{i}. {shape}");
                i++;
            }
        }

        static Shape CreateNewShape()
        {
            Console.WriteLine("Please choose a wanted shape");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Diamond");
            Console.WriteLine("5. Trapeze");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Fill shape when printing it? (y/n)");          
            bool fill = Console.ReadLine() == "y" ? true: false;
            
            Console.WriteLine("Insert characterizing char"); 
            char Char = '#';

            try
            {
                Char = Console.ReadLine()[0];
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("No char entered. Placed '#' instead.");
            }            

            switch (choice)
            {
                case 1: // Rectangle
                    Console.WriteLine("Enter height");
                    int height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Width");
                    int width = Convert.ToInt32(Console.ReadLine());
                    return new Rectangle(fill, Char, height, width);      
                case 2: // Square
                    Console.WriteLine("Enter edge length");
                    int sEdgeLength = Convert.ToInt32(Console.ReadLine());
                    return new Square(fill, Char, sEdgeLength);
                case 3: // Triangle
                    Console.WriteLine("Enter edge length");
                    int tEdgeLength = Convert.ToInt32(Console.ReadLine());
                    return new Triangle(fill, Char, tEdgeLength);
                case 4: // Diamond
                    Console.WriteLine("Enter edge length");
                    int dEdgeLength = Convert.ToInt32(Console.ReadLine());
                    return new Diamond(fill, Char, dEdgeLength);
                default: // Trapeze, assume no bad entry
                    Console.WriteLine("Enter top base");
                    int topBase = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter height");
                    int Height = Convert.ToInt32(Console.ReadLine());
                    return new Trapeze(fill, Char, topBase, Height);     
            }
        }



        static int ChooseShapeForAction(List<Shape> shapes, string action)
        {
            Console.WriteLine($"Please choose a shape to {action}.");
            PrintShapeList(shapes);
            int chosenShapeIndex = Convert.ToInt32(Console.ReadLine());
            return chosenShapeIndex - 1;
        }

        static List<Shape> UpdateShape(List<Shape> shapes)
        {
            int chosenShapeIndex = ChooseShapeForAction(shapes, "update");
            shapes[chosenShapeIndex].UpdateShape(); // assume no bad input
            return shapes;
        } 

        static List<Shape> DeleteShape(List<Shape> shapes)
        {
            int chosenShapeIndex = ChooseShapeForAction(shapes, "delete");
            shapes.RemoveAt(chosenShapeIndex); // assume no bad input
            return shapes;
        }

        static void PrintShape(List<Shape> shapes)
        {
            int chosenShapeIndex = ChooseShapeForAction(shapes, "print");
            shapes[chosenShapeIndex].PrintShape(); // assume no bad input
        }        

        static List<Shape> HandleChosenAction(List<Shape> shapes, int choice)
        {
            switch (choice)
            {
                case 1:
                    shapes.Add(CreateNewShape());
                    break;
                case 2:
                    shapes = UpdateShape(shapes);
                    break;
                case 3:
                    shapes = DeleteShape(shapes);
                    break;
                case 4:
                    PrintShape(shapes);
                    break;
            }
            Console.WriteLine("");
            return shapes;
        }

        static int DisplayMainMenu(List<Shape> shapes)
        {
            int choice;
            if (shapes.Count == 0)
            {
                Console.WriteLine("No shapes yet, please create a new one");
                choice = 1;
            }
            else
            {
                Console.WriteLine("Choose an action");
                Console.WriteLine("Enter '1' for creating a new shape");
                Console.WriteLine("Enter '2' for updating an existing shape");
                Console.WriteLine("Enter '3' for deleting an existing shape");
                Console.WriteLine("Enter '4' for printing a shape");
                Console.WriteLine("Enter '-1' for printing a shape");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");         
            return choice;
        }

        static void RunProgram()
        {
            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("start");
            
            int choice;
            do 
            {
                choice = DisplayMainMenu(shapes);
                if(choice == -1)
                    break;
                HandleChosenAction(shapes, choice);
            }
            while (true);
            
        }


        static void Main(string[] args)
        {
            RunProgram();    
        }

    }

}

