using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresProject
{
    internal class Rectangle : Figures
    {  
        private int _width;
        
        public Rectangle(int width, int height) : base()
        {
            this._width = width;
            this._height = height;
        }

        public Rectangle(int width, int height, bool isFilled, char figurePoint) : base(isFilled, figurePoint) 
        {
            this._width = width;
            this._height = height;            
        }
        
        public override void Draw()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    if (_isFilled)
                    {
                        Console.Write(_figurePoint);
                    }
                    else
                    {
                        if (i == 0 || i == _height - 1 || j == 0 || j == _width - 1)
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

        public int Width { get; set; }
       

        public override string ToString()
        {
            return $"Rectangle: width = {_width}, height = {this._height}" + " " + base.ToString();
        }
    }
    
}
