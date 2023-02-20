abstract class Shape
{
    protected char id { get; set; }
    protected bool isFull { get; set; }

    protected Shape(bool isFull, char id = '#')
    {
        this.id = id;
        this.isFull = isFull;
    }
    public abstract void Print();
}