using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        protected int _width;
        public int Width
        {
            set { _width = value; }
        }

        protected int height;
        public int Height
        { 
            set { height = value; } 
        }
        // Default Constructor
        public Rectangle() : base()
        {
            this._width = 3;
            this.height = 4;
        }

        public Rectangle(bool isFilled, int width, int height, char fillWithChar = '#')
        {
            this._width = width;
            this.height = height;
            this._isFilled = isFilled;
            this.fillWithChar = fillWithChar;
        }
        
        public override void print()
        {
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this._width; j++)
                {
                    if(this._isFilled)
                        Console.Write(this.fillWithChar);
                    else if (i == 0 || i == this.height - 1)
                        Console.Write(this.fillWithChar);
                    else if (j == 0 || j == this._width - 1)
                        Console.Write(this.fillWithChar);
                    else Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public override void update()
        {
            Console.WriteLine("Do you want to change the width? y/n");
            bool toChange = char.Parse(Console.ReadLine()).Equals('y') ? true : false;
            if (toChange)
            {
                Console.WriteLine("Type new width:");
                this._width = int.Parse(Console.ReadLine()); ;
            }
            Console.WriteLine("Do you want to change the height? y/n");
            toChange = char.Parse(Console.ReadLine()).Equals('y') ? true : false;
            if (toChange)
            {
                Console.WriteLine("Type new height:");
                this.height = int.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            return $"Rectangle: \n" +
                $"Width: {_width}, Height: {height} \n" +
                $"Fill: {_isFilled}, Fill with char: {fillWithChar}";
        }

        public override void createShape()
        {
            Console.WriteLine("Type width:");
            this.Width = int.Parse(Console.ReadLine());
            Console.WriteLine("Type height:");
            this.Height = int.Parse(Console.ReadLine());
        }
    }
}
