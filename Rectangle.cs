using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Rectangle : Shape
{
    private int _firstEdgeLength;
    public int FirstEdgeLength
    {
        get { return _firstEdgeLength; }
        set { _firstEdgeLength = value; }
    }
    private int _secondEdgeLength;
    public int SecondEdgeLength
    {
        get { return _secondEdgeLength; }
        set { _secondEdgeLength = value; }
    }
    public Rectangle(int firstEdgeLength, int secondEdgeLength) : base(4)
    {
        this._firstEdgeLength = firstEdgeLength;
        this._secondEdgeLength = secondEdgeLength;
    }
    public override void PrintShape()
    {
        for (int row = 0; row < this._firstEdgeLength; row++)
        {
            for (int column = 0; column < this._secondEdgeLength; column++)
                if (row == 0 || column == 0 || row == this._firstEdgeLength - 1 || column == this._secondEdgeLength - 1)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            Console.WriteLine();
        }
    }
    public override void PrintShapeFill()
    {
        for (int row = 0; row < this._firstEdgeLength; row++)
        {
            for (int col = 0; col < this._secondEdgeLength; col++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }
    public override string ToString()
    {
        return "First Edge :" + this._firstEdgeLength + ", Second Edge :" + this._secondEdgeLength;
    }
}