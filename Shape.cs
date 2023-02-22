using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class Shape
{
    protected int _numberOfEdges;
    public int NumberOfEdges
    {
        get { return _numberOfEdges; }
        set { _numberOfEdges = value; }
    }
    public Shape(int numberOfEdges)
    {
        this._numberOfEdges = numberOfEdges;
    }
    public abstract void PrintShape();
    public abstract void PrintShapeFill();
}