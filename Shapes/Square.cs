using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Rectangle
    {
        public Square() : base() 
        {
            this._width = 3;
            this.height = 3;
        }

        public Square(bool isFilled, int size, char fillWithChar = '#')
        {
            this._width = size;
            this.height = size;
            this._isFilled = isFilled;
            this.fillWithChar = fillWithChar;
        }

        public int Height
        {
            set
            {
                _width = value;
                height = value;
            }
        }

        public int Width 
        {
            set
            {
                _width = value;
                height = value;
            }
        }

        public int Size
        {
            set
            {
                _width = value;
                height = value;
            }
        }

        public override string ToString()
        {
            return $"Square: \n" +
                $"Size: {height} \n" +
                $"Fill: {_isFilled}, Fill with char: {fillWithChar}";
        }

        public override void update()
        {
            Console.WriteLine("Do you want to change the size? y/n");
            bool toChange = char.Parse(Console.ReadLine()).Equals('y') ? true : false;
            if (toChange)
            {
                Console.WriteLine("Type new size:");
                this._width = int.Parse(Console.ReadLine());
                this.height = this._width;
            }
        }

        public override void createShape()
        {
            Console.WriteLine("Type size:");
            this.Width = int.Parse(Console.ReadLine());
            this.Height = this._width;
        }
    }
}
