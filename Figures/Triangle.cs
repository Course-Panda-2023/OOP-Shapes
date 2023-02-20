using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresProject
{
   internal class Triangle : Figures
    {
        
        public Triangle(int height) : base()
        {
            this._height = height;           
        }
        public Triangle(int height, bool isFilled, char figurePoint) : base(isFilled, figurePoint)
        {
            this._height = height;           
        }
        void isString()
        {
            Console.WriteLine("Triangle");

        }
        
        public override void Draw()
        {
            int jInit = (_height * 2 - 1) / 2;
            for(int i = 0; i < _height; i++)
            {                
                for(int j = 0; j < _height * 2 - 1; j++)
                {
                    if(_isFilled)
                    {
                        if(j >= jInit - i && j <= jInit + i)
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
                        if(j == jInit - i || j == jInit + i || i == _height - 1)
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
        
        public override string ToString()
        {
            return $"Triangle: height = {_height}" + " " + base.ToString();
        }
    }
}
