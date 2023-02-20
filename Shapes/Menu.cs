namespace Shapes
{
    public class Menu
    {

        public static void AddShape(List<Shape> shapes)
        {
            Console.WriteLine("Choose a shape to add!");
            Console.WriteLine("Send 1 for Triangle, " +
                "Send 2 for Square, " +
                "Send 3 for Trapezoid," +
                "Send 4 for Rhombus, " +
                "Send 5 for Rectengle, " +
                "Send 6 for Paraleogram.");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Please enter Triangle's Height, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int heightTri = int.Parse(Console.ReadLine());
                    bool isFillTri = bool.Parse(Console.ReadLine());
                    char signTri = char.Parse(Console.ReadLine());
                    Shape tri = new Triangle(heightTri, isFillTri, signTri);
                    shapes.Add(tri);
                    break;
                case 2:
                    Console.WriteLine("Please enter Square's edge, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int edgeSqr = int.Parse(Console.ReadLine());
                    bool isFillSqr = bool.Parse(Console.ReadLine());
                    char signSqr = char.Parse(Console.ReadLine());
                    Shape sqr = new Square(edgeSqr, isFillSqr, signSqr);
                    shapes.Add(sqr);
                    break;
                case 3:
                    Console.WriteLine("Please enter Trapezoid's Height, both bases length, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int heightTrp = int.Parse(Console.ReadLine());
                    int baseOneTrp = int.Parse(Console.ReadLine());
                    int baseTwoTrp = int.Parse(Console.ReadLine());
                    bool isFillTrp = bool.Parse(Console.ReadLine());
                    char signTrp = char.Parse(Console.ReadLine());
                    Shape trp = new Trapezoid(isFillTrp, signTrp, baseOneTrp, baseTwoTrp, heightTrp);
                    shapes.Add(trp);
                    break;
                case 4:
                    Console.WriteLine("Please enter Rhombus's edge, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int edgeRhm = int.Parse(Console.ReadLine());
                    bool isFillRhm = bool.Parse(Console.ReadLine());
                    char signRhm = char.Parse(Console.ReadLine());
                    Shape rhm = new Rhombus(edgeRhm, isFillRhm, signRhm);
                    shapes.Add(rhm);
                    break;
                case 5:
                    Console.WriteLine("Please enter Rectengle's edge, second edge, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int edgeRec = int.Parse(Console.ReadLine());
                    int edgeRecTwo = int.Parse(Console.ReadLine());
                    bool isFillRec = bool.Parse(Console.ReadLine());
                    char signRec = char.Parse(Console.ReadLine());
                    Shape rec = new Rectengle(edgeRec, isFillRec, signRec, edgeRecTwo);
                    shapes.Add(rec);
                    break;
                case 6:
                    Console.WriteLine("Please enter Parallelogram's width, height, edge, true/false for " +
                        "if the shape is filled or not, and a char sign for the shape.");
                    int widthPar = int.Parse(Console.ReadLine());
                    int heightPar = int.Parse(Console.ReadLine());
                    int edgePar = int.Parse(Console.ReadLine());
                    bool isFillPar = bool.Parse(Console.ReadLine());
                    char signPar = char.Parse(Console.ReadLine());
                    Shape par = new Parallelogram(isFillPar, signPar, heightPar, widthPar, edgePar);
                    shapes.Add(par);
                    break;
            }
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
            while (true)
            {
                Console.WriteLine("Welcome to shapes world!");
                Console.WriteLine("SEND 1 TO CREATE NEW SHAPE " +
                    "SEND 2 TO UPDATE EXISTING SHAPE " +
                    "SEND 3 TO DELETE EXISTING SHAPE " +
                    "SEND 4 TO PRINT SHAPE ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        AddShape(shapes);
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
