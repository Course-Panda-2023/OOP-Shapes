using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FiguresProject
{
    internal class Trapezoid : Figures
    {
        private int _upperSide;
        //private int _baseSide;
        

        public Trapezoid(int upperSide, int height) : base()
        {
            this._upperSide = upperSide;
            //this._baseSide = baseSide;
            this._height = height;
        }
        public Trapezoid(int upperSide, int height, bool isFilled, char figurePoint) : base(isFilled, figurePoint)
        {
            this._upperSide = upperSide;
            //this._baseSide = baseSide;
            this._height = height;
        }


        public override void Draw()
        {
            int jInit = (_height * 2 ) / 2;
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _height * 2 + 1; j++)
                {
                    if (_isFilled)
                    {
                        if (j >= jInit - _upperSide/2 - i && j <= jInit + _upperSide / 2  +  i)
                        {
                            Console.Write(_figurePoint);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j == jInit - i - _upperSide / 2 || j == jInit + i + _upperSide / 2 || i == _height - _upperSide / 2
                                                              || (i == 0 && j < jInit + _upperSide / 2 && j > jInit - _upperSide / 2))
                        {
                            Console.Write(_figurePoint);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        public int UpperSide { get; set; }
        
        public override string ToString()
        {
            return $"Trapezoid: upperside size = {this._upperSide}, height = {this._height}" + " " + base.ToString();
        }
    }   
}
