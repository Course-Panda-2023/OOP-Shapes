class Rhombus : Shape
{
    protected int height { get; set; }
    protected int edgeLength { get; set; }

    public Rhombus(int edgeLength, int height, bool isFull, char id = '#') : base(isFull, id)
    {
        this.edgeLength = edgeLength;
        this.height = height;
    }
    private int edgeXIndentation(int y)
    {
        double angle = Math.Asin((double)this.height / (double)this.edgeLength);
        double indentation = y / Math.Tan(angle);
        return (int)Math.Ceiling(indentation);
    }
    private int edgeWidth()
    {
        return (int)Math.Floor((double)this.edgeLength / (double)this.height);
    }
    private bool IsEdge(int h, int w)
    {
        int indentation = edgeXIndentation(h);
        return (h == 0 || h == this.height - 1 || (indentation <= w && w <= indentation + edgeWidth()) || (this.edgeLength - 1 + indentation <= w && w <= this.edgeLength - 1 + indentation + edgeWidth()));
    }
    public override void Print()
    {
        for (int h = 0; h < this.height; h++)
        {
            string line = "";
            int indentation = edgeXIndentation(h);
            for (int i = 0; i < indentation; i++)
            {
                line += "  ";
            }

            for (int w = indentation; w < this.edgeLength + indentation + edgeWidth(); w++)
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
}