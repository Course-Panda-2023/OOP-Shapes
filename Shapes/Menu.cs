namespace Shapes
{
    public class Menu
    {
        public static Shape CreateNewShape()
        {
            int SQUARE_NUM = 2;
            int TRAPEZOID_NUM = 3;
            int RHOMBUS_NUM = 4;
            int RECTENGLE_NUM = 5;
            int PARALEOGRAM_NUM = 6;
            int TRIANGLE_NUM = 1;
            Console.WriteLine("Choose a shape to add!");
            Console.WriteLine($"Send {TRIANGLE_NUM} for Triangle, " +
                $"Send {SQUARE_NUM} for Square, " +
                $"Send {TRAPEZOID_NUM} for Trapezoid," +
                $"Send {RHOMBUS_NUM} for Rhombus, " +
                $"Send {RECTENGLE_NUM} for Rectengle, " +
                $"Send {PARALEOGRAM_NUM} for Paraleogram.");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Please enter Triangle's Height, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int heightTri = int.Parse(Console.ReadLine());
                    bool isFillTri = bool.Parse(Console.ReadLine());
                    char signTri = char.Parse(Console.ReadLine());
                    Shape tri = new Triangle(heightTri, isFillTri, signTri);
                    return tri;
                case 2:
                    Console.WriteLine("Please enter Square's edge, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int edgeSqr = int.Parse(Console.ReadLine());
                    bool isFillSqr = bool.Parse(Console.ReadLine());
                    char signSqr = char.Parse(Console.ReadLine());
                    Shape sqr = new Square(edgeSqr, isFillSqr, signSqr);
                    return sqr;
                case 3:
                    Console.WriteLine("Please enter Trapezoid's Height, both bases length, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int heightTrp = int.Parse(Console.ReadLine());
                    int baseOneTrp = int.Parse(Console.ReadLine());
                    int baseTwoTrp = int.Parse(Console.ReadLine());
                    bool isFillTrp = bool.Parse(Console.ReadLine());
                    char signTrp = char.Parse(Console.ReadLine());
                    Shape trp = new Trapezoid(isFillTrp, signTrp, baseOneTrp, baseTwoTrp, heightTrp);
                    return trp;
                case 4:
                    Console.WriteLine("Please enter Rhombus's edge, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int edgeRhm = int.Parse(Console.ReadLine());
                    bool isFillRhm = bool.Parse(Console.ReadLine());
                    char signRhm = char.Parse(Console.ReadLine());
                    Shape rhm = new Rhombus(edgeRhm, isFillRhm, signRhm);
                    return rhm;
                case 5:
                    Console.WriteLine("Please enter Rectengle's edge, second edge, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int edgeRec = int.Parse(Console.ReadLine());
                    int edgeRecTwo = int.Parse(Console.ReadLine());
                    bool isFillRec = bool.Parse(Console.ReadLine());
                    char signRec = char.Parse(Console.ReadLine());
                    Shape rec = new Rectengle(edgeRec, isFillRec, signRec, edgeRecTwo);
                    return rec;
                case 6:
                    Console.WriteLine("Please enter Parallelogram's width, height, edge, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int widthPar = int.Parse(Console.ReadLine());
                    int heightPar = int.Parse(Console.ReadLine());
                    int edgePar = int.Parse(Console.ReadLine());
                    bool isFillPar = bool.Parse(Console.ReadLine());
                    char signPar = char.Parse(Console.ReadLine());
                    Shape par = new Parallelogram(isFillPar, signPar, heightPar, widthPar, edgePar);
                    return par;
            }
            return new Triangle(10,true,'$');
        }

        public static void PrintShapesWithIndexes(List<Shape> shapes)
        {
            int indexer = 1;
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{indexer}: {shape.GetType()}");
            }
        }
        public static void Run(List<Shape> shapes)
        {
            int NEW_SHAPE_NUM = 2;
            int UPDATE_NUM = 2;
            int DELETE_NUM = 2;
            int PRINT_NUM = 2;
            int STOP_RUN = -1;
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to shapes world!");
                Console.WriteLine($"SEND {NEW_SHAPE_NUM} TO CREATE NEW SHAPE " +
                    $"SEND {UPDATE_NUM} TO UPDATE EXISTING SHAPE " +
                    $"SEND {DELETE_NUM} TO DELETE EXISTING SHAPE " +
                    $"SEND {PRINT_NUM} TO PRINT SHAPE ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Shape newShape = CreateNewShape();
                        shapes.Add(newShape);
                        break;
                    case 2:
                        Shape shape = ChooseShape(shapes, "enter index of the shape you would like to update: ");
                        int STOP_FLAG = -1;
                        Console.WriteLine("Enter shape's new size Parametrs, -1 value when finish");
                        Dictionary<string, int> shapeParams = GetShapeParameters();
                        Console.WriteLine("shape filled? (enter true/false)");
                        bool isFilled = bool.Parse(Console.ReadLine());
                        Console.WriteLine("shape sign? (enter char)");
                        char sign = char.Parse(Console.ReadLine());
                        shape.Update(shapeParams, isFilled, sign);
                        break;
                    case 3:
                        Shape shapeToRemove = ChooseShape(shapes, "choose shape to delete: ");
                        shapes.Remove(shapeToRemove);
                        break;
                    case 4:
                        Shape shapeToPrint = ChooseShape(shapes, "choose shape to print: ");
                        shapeToPrint.Print();
                        break;
                }
                Console.WriteLine("ENTER true to continue running, false to stop");
                isRunning = bool.Parse(Console.ReadLine());
            }
        }
        public static Shape ChooseShape(List<Shape> shapes, string messege)
        {
            PrintShapesWithIndexes(shapes);
            Console.WriteLine(messege);
            int shapeIndex = int.Parse(Console.ReadLine()) - 1;
            return shapes[shapeIndex];
        }

        public static Dictionary<string,int> GetShapeParameters()
        {
            Console.WriteLine("Enter shape's new size Parametrs, -1 value when finish");
            Dictionary<string, int> shapeParams = new Dictionary<string, int>();
            Console.WriteLine("parameter name: ");
            string key = Console.ReadLine();
            Console.WriteLine("parameter value: ");
            int value = int.Parse(Console.ReadLine());
            while (value != -1)
            {
                shapeParams.Add(key, value);
                Console.WriteLine("parameter name: ");
                key = Console.ReadLine();
                Console.WriteLine("parameter value: ");
                value = int.Parse(Console.ReadLine());
            }
            return shapeParams;
        }
    }
}
