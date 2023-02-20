public class Shape
{
    public int Size { get; set; }
    public char Fill { get; set; }

    public Shape(int size, char fill)
    {
        Size = size;
        Fill = fill;
    }

    public virtual void Draw(bool isFilled)
    {
        Console.WriteLine("invalid shape");
    }

    public virtual void PrintDetails()
    {
        Console.Write($"Default Shape. Size: {this.Size}");
    }

    public virtual void ShapeEditPrompt()
    {
        Console.WriteLine("empty shape, cannot edit");
    }
}
