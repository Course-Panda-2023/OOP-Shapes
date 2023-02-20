using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresProject
{
    internal class Rhombus : Figures
    {
        public Rhombus(int height) : base()
        {   
        //this.width = width;
            this._height = height;
        }
        public Rhombus(int height, bool isFilled, char figurePoint) : base(isFilled, figurePoint)
        {
            
            this._height = height;
        }
        public override void Draw()
        {
            int jInit = (_height * 2 - 1) / 2;
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < jInit*2 + 1; j++)
                {
                    if (_isFilled)
                    {
                        if (j >= jInit - i && j <= jInit + i)
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
                        if (j == jInit - i || j == jInit + i)
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
            for (int i = _height - 2; i >= 0; i--)
            {
                for (int j = 0; j < jInit * 2 + 1; j++)
                {
                    if (_isFilled)
                    {
                        if (j >= jInit - i && j <= jInit + i)
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
                        if (j == jInit - i || j == jInit + i)
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
            return $"Rhombus: height = {_height}" + " " + base.ToString();
        }
    }
}
