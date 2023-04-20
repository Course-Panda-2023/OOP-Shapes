public class ShapesManager
{
    public List<Shape> ShapeList;

    public ShapesManager()
    {
        ShapeList = new List<Shape>();
    }

    public ShapesManager(List<Shape> shapes)
    {
        this.ShapeList = shapes;
    }

    public void AddShape(Shape shape)
    {
        ShapeList.Add(shape);
    }

    public void RemoveShape(Shape shape)
    {
        ShapeList.Remove(shape);
    }

    public void PrintAllShapes()
    {
        int i = 0;
        foreach (Shape shape in ShapeList)
        {
            Console.Write(i + " ");
            shape.PrintDetails();
            i++;
            Console.WriteLine();
        }
    }
}
