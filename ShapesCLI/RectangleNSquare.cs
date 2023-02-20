class Rectangle : Shape
{
    protected int height { get; set; }
    protected int width { get; set; }

    public Rectangle(int height, int width, bool isFull, char id = '#') : base(isFull, id)
    {
        this.height = height;
        this.width = width;
    }
    public override void Print()
    {
        for (int h = 0; h < this.height; h++)
        {
            string line = "";
            for (int w = 0; w < this.width; w++)
            {
                if (base.isFull || IsEdge(h, w))
                {
                    line += base.id + " ";
                }
                else
                {
                    line += "  ";
                }
            }
            Console.WriteLine(line);
        }
    }
    private bool IsEdge(int h, int w)
    {
        return (h == 0 || h == this.height - 1 || w == 0 || w == this.width - 1);
    }
}
class Square : Rectangle
{
    public Square(int height, bool isFull, char id = '#') : base(height, height, isFull, id) { }

}