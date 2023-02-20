using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Shapes
{
    public enum ShapeType
    {
        Rhombus,
        Rectangle,
        Square,
        Triangle,
        Trapezoid
    };
    class HelperFunctions
    {
        private static void updateFields(Shape shape)
        {
            Console.WriteLine("Do you want to fill the shape in the print? y/n");
            shape.Fill = char.Parse(Console.ReadLine()) == 'y' ? true : false;
            Console.WriteLine("Do you want to change the char to fill with? y/n (default: #)");
            char ch = char.Parse(Console.ReadLine());
            bool toFillWith = ch == 'y' ? true : false;
            if (toFillWith)
            {
                Console.WriteLine("Type the new char you want to change to:");
                shape.FillWithChar = char.Parse(Console.ReadLine());
            }
        }
        
        public static Shape CreateShape(ShapeType shapeType) 
        {
            FactoryShape factoryShape = new FactoryShape();
            Shape shape = factoryShape.GetShape(shapeType);
            switch (shapeType)
                {
                case (ShapeType.Rectangle):
                    Console.WriteLine("Type width:");
                    ((Rectangle)shape).Width = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type height:");
                    ((Rectangle)shape).Height = int.Parse(Console.ReadLine());
                    break;
                case (ShapeType.Square):
                    Console.WriteLine("Type size:");
                    int size = int.Parse(Console.ReadLine());
                    ((Square)shape).Size = size;
                    break;
                case (ShapeType.Trapezoid):
                    Console.WriteLine("Type upper base:");
                    ((Trapezoid)shape).UpperBase = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type height:");
                    ((Trapezoid)shape).Height = int.Parse(Console.ReadLine());
                    break;
                case (ShapeType.Triangle):
                    Console.WriteLine("Type height:");
                    ((Triangle)shape).Height = int.Parse(Console.ReadLine());
                    break;
                case (ShapeType.Rhombus):
                    Console.WriteLine("Type half height:");
                    ((Rhombus)shape).HalfHeight = int.Parse(Console.ReadLine());
                    break;
            }
            updateFields(shape);
            return shape;
        }
        
        public static void PrintMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("0.Exit");
            Console.WriteLine("1.Create new shape");
            Console.WriteLine("2.Update exist shape");
            Console.WriteLine("3.Remove exist shape");
            Console.WriteLine("4.Print shape");
        }

        public static ShapeType ChooseShape()
        {
            Console.WriteLine("1. Rhombus");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Square");
            Console.WriteLine("4. Triangle");
            Console.WriteLine("5. Trapezoid");
            Console.Write("Your select (type  number): ");
            int shapeNumber = int.Parse(Console.ReadLine());
            Dictionary<int, string> map = new Dictionary<int, string>();
            map[1] = "Rhombus";
            map[2] = "Rectangle";
            map[3] = "Square";
            map[4] = "Triangle";
            map[5] = "Trapezoid";
            ShapeType shapeType;
            Enum.TryParse<ShapeType>(map[shapeNumber], out shapeType);
            return shapeType;
        }

        public static void InitiateTheDictionary(Dictionary<ShapeType, List<Shape>> shapes)
        {
            List<ShapeType> enumsValues = Enum.GetValues(typeof(ShapeType)).Cast<ShapeType>().ToList();
            foreach (ShapeType shape in enumsValues) 
                shapes[shape] = new List<Shape>();
        }
    
        public static void PrintAllShapeFromType(List<Shape> listShapes)
        {
            for (int i = 0; i < listShapes.Count; i++)
                Console.WriteLine($"{i+1}. {listShapes[i]}");
        }

        public static void UpdateShape(Shape shape, ShapeType shapeType)
        {
            updateFields(shape);
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    ((Rectangle)shape).update();
                    break;
                case ShapeType.Square:
                    ((Square)shape).update();
                    break;
                case ShapeType.Triangle:
                    ((Triangle)shape).update();
                    break;
                case ShapeType.Trapezoid:
                    ((Trapezoid)shape).update();
                    break;
                case ShapeType.Rhombus:
                    ((Rhombus)shape).update();
                    break;
            }
        }
    }
}
