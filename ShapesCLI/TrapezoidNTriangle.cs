class Trapezoid : Shape
{
    protected int height { get; set; }
    protected int smallBase { get; set; }
    protected int largeBaseLeftbulge { get; set; }
    protected int largeBaseRightbulge { get; set; }


    public Trapezoid(int height, int smallBase, int largeBaseLeftbulge, int largeBaseRightbulge, bool isFull, char id = '#') : base(isFull, id)
    {
        this.height = height;
        this.smallBase = smallBase;
        this.largeBaseLeftbulge = largeBaseLeftbulge;
        this.largeBaseRightbulge = largeBaseRightbulge;
    }
    private int edgeXIndentation(int y, string edge)
    {
        int bulge = 0;
        if (edge == "left") { bulge = largeBaseLeftbulge; }
        else if (edge == "right") { bulge = largeBaseRightbulge; }
        double indentation = y * (double)bulge / (double)this.height;
        if (edge == "left") { return bulge - (int)Math.Ceiling(indentation); }
        else if (edge == "right") { return 2 * (int)Math.Ceiling(indentation); }
        return 0;

    }
    private int leftEdgeWidth()
    {
        return Math.Max(1, (int)Math.Floor((double)this.largeBaseLeftbulge / (double)this.height));
    }
    private int rightEdgeWidth()
    {
        return ((int)Math.Floor((double)(this.largeBaseRightbulge) / (double)this.height)) * 2 + 1;
    }

    public override void Print()
    {

        for (int h = 0; h < this.height; h++)
        {
            char fill = ' ';
            if (this.isFull) { fill = this.id; }
            if (h == 0 || h == this.height - 1)
            {
                fill = this.id;
            }
            string line = "";
            line += new string(' ', Math.Abs(edgeXIndentation(h, "left")));
            line += new string(this.id, leftEdgeWidth());
            line += new string(fill, largeBaseLeftbulge - Math.Abs(edgeXIndentation(h, "left")));
            line += new string(fill, smallBase);
            line += new string(fill, Math.Abs(edgeXIndentation(h, "right")));
            line += new string(this.id, rightEdgeWidth());
            Console.WriteLine(line);
        }
    }
}
class Triangle : Trapezoid
{
    public Triangle(int height, int largeBaseLeftbulge, int largeBaseRightbulge, bool isFull, char id = '#') : base(height, 0, largeBaseLeftbulge, largeBaseRightbulge, isFull, id) { }
}