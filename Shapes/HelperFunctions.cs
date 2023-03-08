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
        const char YES = 'y';
        private static void updateFields(Shape shape)
        {
            Console.WriteLine("Do you want to fill the shape in the print? y/n");
            shape.Fill = char.Parse(Console.ReadLine()) == YES ? true : false;
            Console.WriteLine("Do you want to change the char to fill with? y/n (default: #)");
            char ch = char.Parse(Console.ReadLine());
            bool toFillWith = ch == YES ? true : false;
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
            shape.createShape();
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
            shape.update();
        }
    }
}
