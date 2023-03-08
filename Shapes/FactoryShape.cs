namespace Shapes
{
    internal class FactoryShape
    {
        public Shape GetShape(ShapeType shape)
        {
            switch (shape)
            {
                case ShapeType.Rhombus:
                    return new Rhombus();
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Triangle:
                    return new Triangle();
                case ShapeType.Square:
                    return new Square();
                default:
                    return new Trapezoid();

            }
        }

    }
}
