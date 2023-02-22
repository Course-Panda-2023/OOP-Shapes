using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Triangle : Shape
{
    private int _edgeLength;
    public int EdgeLength
    {
        get { return _edgeLength; }
        set { _edgeLength = value; }
    }
    public Triangle(int edgeLength) : base(3)
    {
        this._edgeLength = edgeLength;
    }
    public override void PrintShape()
    {
        for (int i = 1; i <= this._edgeLength; i++)
        {
            for (int j = 1; j <= i; j++)
                if (j == 1 || i == j || i == this._edgeLength)
                    Console.Write("*");
                else
                    Console.Write(" ");
            Console.WriteLine();
        }
    }
    public override void PrintShapeFill()
    {
        for (int i = 1; i <= this._edgeLength; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
    public override string ToString()
    {
        return "Edge Length :" + this._edgeLength;
    }
}