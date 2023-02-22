using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Rhombus : Shape
{
    private int _edgeLength;
    public int EdgeLength
    {
        get { return _edgeLength; }
        set { _edgeLength = value; }
    }
    public Rhombus(int edgeLength) : base(4)
    {
        this._edgeLength = edgeLength;
    }
    public override void PrintShape()
    {
        for (int i = 1; i <= this._edgeLength; i++)
        {
            for (int j = 1; j <= this._edgeLength - i; j++)
                Console.Write(" ");
            if (i == 1 || i == this._edgeLength)
                for (int j = 1; j <= this._edgeLength; j++)
                    Console.Write("*");
            else
                for (int j = 1; j <= this._edgeLength; j++)
                    if (j == 1 || j == this._edgeLength)
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
            for (int j = 1; j <= this._edgeLength - i; j++)
                Console.Write(" ");
            for (int j = 1; j <= this._edgeLength; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
    public override string ToString()
    {
        return "Edge Length :" + this._edgeLength;
    }
}