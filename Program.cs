// See https://aka.ms/new-console-template for more information
using CLIShape;

Console.WriteLine("Hello, World!");

//Square s = new Square(false,'$',5) ;
//s.Print();

//Rectangle r = new Rectangle(false, '*', 3, 5);
//r.Print();

//Triangle t = new Triangle(false, '^', 5);
//t.Print();

//Rhombus r = new Rhombus(false, '!', 7);
////r.Print();

//Trapeze t = new Trapeze(true, '0', 5, 20, 6);
//t.Print();

ShapeFactory MyShapFactory= new ShapeFactory();
MyShapFactory.Run();