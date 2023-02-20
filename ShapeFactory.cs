using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIShape
{
    internal class ShapeFactory
    {
        private Dictionary<char,Shape> shapes = new Dictionary<char, Shape>();

        public ShapeFactory() 
        {

        }


        public Shape createShap(string shape)
        {

            string input = "";
            int x, y,z;
            char id, boolInput;
            bool fillIn = false;
            List<string> shapesProp = Shape.Getproperties(shape);

            do
            {
                Console.WriteLine($"Would you like to fillIn the {shape}: [Y] for yes [N] for no");
                boolInput = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

            } while (!(boolInput == 'Y' || boolInput == 'N'));

            if (boolInput == 'Y')
                fillIn = true;

            do
            {
                Console.WriteLine($"Enter {shape} charId:");
                id = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (id==' '||id =='\r' || shapes.Keys.ToList().Contains(id));


            do
            {
                Console.WriteLine($"Enter {shapesProp[0]} :");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out x));
            
            if(shapesProp.Count == 1) 
            {
                switch (shape)
                {
                    case "square":
                        return new Square(fillIn, id, x);
                
                    case "rhombus":
                        return new Rhombus(fillIn, id, x);

                    case "triangle":
                        return new Triangle(fillIn, id, x); 

                }
            }

            do
            {
                Console.WriteLine($"Enter {shapesProp[1]} :");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out y));

            if(shape == "rectangle") 
                return new Rectangle(fillIn, id, x, y); 

            do
            {
                Console.WriteLine($"Enter {shapesProp[2]} :");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out z));
            
            return new Trapeze(fillIn, id, x, y, z);    


        }

        /// <summary>
        /// /////////////////
        /// </summary>
        /// 

        public void UpdateShap()
        {
            char shapeId;
            Shape shape;
            char boolInput ;


            do
            {
                Console.WriteLine($"Enter shap to change charId:");
                shapeId = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (shapeId == ' ' || shapeId == '\r' || !shapes.Keys.ToList().Contains(shapeId));

            shape = shapes[shapeId];

            do
            {
                Console.WriteLine($"Would you like to change {shape.GetType()}{shapeId} the fillIn [Y] for yes [N] for no");
                boolInput = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

            } while (!(boolInput == 'Y' || boolInput == 'N'));

            if (boolInput == 'Y')
                shape.FillIn=!shape.FillIn;
        }


        public void Run()
        {
            string input1,input2,input3;
            List<string> validInput = new List<string>() {"C","D","U","P","U" };
            Dictionary<string , Action> toDO = new Dictionary<string, Action>() ;
            bool error=false;
            char c;
            while (true)
            {
                if (shapes.Keys.Count > 0)
                {
                    Console.Write ("\n{");
                    foreach (char key in shapes.Keys.ToList()) 
                    {
                        Console.Write($"{key} : {shapes[key].GetType().ToString()} ,");
                    }
                    Console.WriteLine("}\n");
                }
                Console.WriteLine("[C] for creating new shap\n[D] for deleting a shap\n[U] for updating a shap\n[P] for printing a shap\n[E] to exit");
                input1 = Console.ReadLine().ToUpper();
                switch (input1)
                {
                    case "C":
                        do
                        {
                            Console.WriteLine("Lets creat a shap\nEnter shap name (square,rectangle,triangle,rhombus,trapeze)");
                            input2 = Console.ReadLine().ToLower();
                            switch (input2)
                            {

                                case "square":
                                    error = false;
                                    Square s = (Square)createShap(input2);
                                    shapes.Add(s.IdChar, s);
                                    break;

                                case "rectangle":
                                    error = false;
                                    Rectangle r = (Rectangle)createShap(input2);
                                    shapes.Add(r.IdChar, r);
                                    break;

                                case "triangle":
                                    error = false;
                                    Triangle t = (Triangle)createShap(input2);
                                    shapes.Add(t.IdChar, t);
                                    break;

                                case "rhombus":
                                    error = false;
                                    Rhombus rh = (Rhombus)createShap(input2);
                                    shapes.Add(rh.IdChar, rh);
                                    break;

                                case "trapeze":
                                    error = false;
                                    Trapeze tr = (Trapeze)createShap(input2);
                                    shapes.Add(tr.IdChar, tr);
                                    break;

                                default:
                                    Console.WriteLine("Invalid input");
                                    error = true;
                                    break;
                            }
                        } while (error);
                        break;

                    case "D":
                        do
                        {
                            Console.WriteLine("Enter shap charId");
                            c = Console.ReadKey().KeyChar;
                        } while (!shapes.Keys.ToList().Contains(c));
                        shapes.Remove(c);
                        break;

                    case "U":
                        if (shapes.Count > 0)
                        {
                            UpdateShap();
                            break;
                        }
                        Console.WriteLine("there are no shapes :(");
                        break;

                    case "E":
                        return;

                    case "P":
                        do
                        {
                            Console.WriteLine("Enter shap charId");
                            c = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                        } while (!shapes.Keys.ToList().Contains(c));
                        shapes[c].Print();   
                        break;


                    default:
                        Console.WriteLine("\nInvalid input");
                        break;
                }
            }
        } 
    }
}
