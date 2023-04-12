using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class CLIwrapper
    {
        ShapeContainer container = new ShapeContainer();
        public static bool exit = false;

        public void mainMenu()
        {
            Console.WriteLine("\n" +
                "insert number to continue\n" +
                "1. Create new Shape\n" +
                "2. Edit existing Shape\n" +
                "3. Erase Shape\n" +
                "4. Draw Shape\n" +
                "5. print all Shapes in list\n" +
                "0. exit");

            int y = ReadIntInput(0, 5);

            switch (y)
            {
                case 1: //create
                    CreateShapeMenu();
                    break;
                case 2: //edit
                    EditShapeMenu();
                    break;
                case 3: //erase
                    EraseShapeMenu();
                    break;
                case 4: //display
                    container.PrintAll();
                    DisplayMenu();
                    break;
                case 5: //display all
                    container.PrintAll();
                    break;
                case 0: //exit
                    exit = true;
                    break;

            }

        }


        public void DisplayMenu()
        {
            Console.WriteLine("enter key of Shape to draw or enter 0 to cancel");
            int key = ReadIntInput(0, int.MaxValue);
            if (key == 0)
                return;
            else
            {
                Shape? s = container.Get(key);
                if (s != null)
                    s.Draw();
            }
        }
        private void EraseShapeMenu()
        {
            Console.WriteLine("enter key of Shape to delete or enter 0 to cancel");
            int key = ReadIntInput(0, int.MaxValue);
            if (key == 0)
                return;
            else
                container.Remove(key);
        }

        public static int ReadIntInput(int min, int max)
        {
            int y = 0;
            bool res;
            do
            {
                res = Int32.TryParse(Console.ReadLine(), out y);
            } while (!res || y < min || y > max);
            return y;
        }
        private void EditShapeMenu()
        {
            container.PrintAll();
            Console.WriteLine("Edit shape with this format: [key, param_name, param_new_value]");
            string? str = Console.ReadLine();
            if (str != null)
                try
                {

                    string[] args = str.Trim().Split(",");
                    int key = Int32.Parse(args[0].Trim());
                    Shape? shape = container.Get(key);
                    if (shape != null)
                        shape.Edit(args[1].Trim().ToLower(), args[2].Trim().ToLower());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("error in parameters:");
                    Console.WriteLine(ex.Message);
                }

        }

        private void CreateShapeMenu()
        {
            Console.WriteLine("\n" +
                "Select Shape to create\n" +
                "1. Rectangle\n" +
                "2. Triangle\n" +
                "3. Trapeze\n" +
                "4. Diamond\n" +
                "5. Square\n" +
                "0. Cancel");

            int y = ReadIntInput(0, 5);

            switch (y)
            {
                case 1:
                    container.Add(Rectangle.Create());
                    break;
                case 2:
                    container.Add(Triangle.Create());
                    break;
                case 3:
                    container.Add(Trapeze.Create());
                    break;
                case 4:
                    container.Add(Diamond.Create());
                    break;
                case 5:
                    container.Add(Square.Create());
                    break;

                case 0:
                    break;
            }
        }
    }
}
