using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Trapeze : Shape
{
    private int _base;
    public int Base
    {
        get { return _base; }
        set { _base = value; }
    }
    private int _height;
    public int Height
    {
        get { return _height; }
        set { _height = value; }
    }
    public Trapeze(int tbase, int height) : base(4) 
    {
        this._base = tbase;
        this._height = height;
    }
    public override void PrintShape()
    {
        int x = this._base;
        int start = 0;
        for (int b = 0; b < this._height; b++)
        {
            for (int i = 0; i < x; i++)
            {
                if (i < start)
                    Console.Write(" ");
                else
                    if (i == start || i == x - 1 || b == 0 || b == this._height - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
            }
            Console.WriteLine();
            start++;
            x--;
        }
    }
    public override void PrintShapeFill()
    {
        int x = this._base;
        int start = 0;
        for (int b = 0; b < this._height; b++)
        {
            for (int i = 0; i < x; i++)
            {
                if (i < start)
                    Console.Write(" ");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
            start++;
            x--;
        }
    }
    public override string ToString()
    {
        return "Base : " + this._base + " , Height : " + this._height;
    }
}