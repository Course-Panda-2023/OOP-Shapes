using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Square : Shape
{
    private int _edgeLength;
    public int EdgeLength
    {
        get { return _edgeLength; }
        set { _edgeLength = value; }
    }
    public Square(int edgeLength) : base(4) 
    {
        this._edgeLength = edgeLength;
    }
    public override void PrintShape()
    {
        for (int row = 0; row < this._edgeLength; row++)
        {
            for (int column = 0; column < this._edgeLength; column++)
                if (row == 0 || column == 0 || row == this._edgeLength - 1 || column == this._edgeLength - 1)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            Console.WriteLine();
        }
    }
    public override void PrintShapeFill()
    {
        for (int row = 0; row < this._edgeLength; row++)
        {
            for (int col = 0; col < this._edgeLength; col++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }
    public override string ToString()
    {
        return "Edge Length :" + this._edgeLength;
    }
}