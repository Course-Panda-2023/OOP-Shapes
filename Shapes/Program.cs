using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // list which saves all the shapes created
            Dictionary<ShapeType, List<Shape>> shapes = new Dictionary<ShapeType, List<Shape>>();
            HelperFunctions.InitiateTheDictionary(shapes);
            Console.WriteLine("Shape World");
            Console.WriteLine("***************");
            HelperFunctions.PrintMenu();
            Console.Write("Your Select: ");
            int choice = int.Parse(Console.ReadLine());
            ShapeType shapeType;
            List<Shape> listShape;
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select which shape do you want to create");
                        shapeType = HelperFunctions.ChooseShape();
                        Shape shape = HelperFunctions.CreateShape(shapeType);
                        if (shape != null)
                            shapes[shapeType].Add(shape);
                        break;
                    case 2:
                        Console.WriteLine("**** Update Shape ****");
                        Console.WriteLine("Choose the shape you want to update");
                        shapeType = HelperFunctions.ChooseShape();
                        listShape = shapes[shapeType];
                        HelperFunctions.PrintAllShapeFromType(listShape);
                        if (listShape.Count > 0)
                        {
                            Console.Write("Choose shape to update:");
                            int chooseShape = int.Parse(Console.ReadLine());
                            Shape Updateshape = listShape[chooseShape];
                            HelperFunctions.UpdateShape(Updateshape, shapeType);
                        }
                        break;
                    case 3:
                        Console.WriteLine("**** Remove Shape ****");
                        Console.WriteLine("Choose the shape you want to remove");
                        shapeType = HelperFunctions.ChooseShape();
                        listShape = shapes[shapeType];
                        HelperFunctions.PrintAllShapeFromType(listShape);
                        if (listShape.Count > 0)
                        {
                            Console.Write("Choose shape to remove:");
                            int chooseShape = int.Parse(Console.ReadLine());
                            listShape.RemoveAt(chooseShape);
                        }
                        break;
                    case 4:
                        Console.WriteLine("**** Printing Shape ****");
                        Console.WriteLine("Choose the shape you want to print");
                        shapeType = HelperFunctions.ChooseShape();
                        listShape = shapes[shapeType];
                        HelperFunctions.PrintAllShapeFromType(listShape);
                        if (listShape.Count > 0)
                        {
                            Console.Write("Choose shape to print:");
                            int chooseShape = int.Parse(Console.ReadLine());
                            listShape[chooseShape - 1].print();
                        }
                        break;
                        
                }
                HelperFunctions.PrintMenu();
                Console.Write("Your Select: ");
                choice = int.Parse(Console.ReadLine());
            }

        }
    }
}
