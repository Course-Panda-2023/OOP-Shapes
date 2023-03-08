using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Shape
    {
        private int _height;
        public int Height
        {
            set
            {
                _height = value;
            }
        }
        public Triangle() : base()
        {
            this._height = 3;
        }

        private void printSpaces(int amount)
        {
            for (int i = 0; i < amount; i++)
                Console.Write(' ');
        }

        public override void print()
        {
            int repeatChar = 1;
            for (int i = this._height - 1; i >= 0; i--)
            {
                printSpaces(i);
                for (int j = 0; j < repeatChar; j++)
                {
                    if (!this._isFilled && j != 0 && j != repeatChar - 1 && i != 0)
                        Console.Write(' ');
                    else 
                        Console.Write(this.fillWithChar);
                }
                printSpaces(i);
                repeatChar += 2;
                Console.WriteLine();
            }
        }

        public override void update()
        {
            Console.WriteLine("Do you want to change the height? y/n");
            bool toChange = char.Parse(Console.ReadLine()).Equals('y') ? true : false;
            if (toChange)
            {
                Console.WriteLine("Type new size:");
                this._height = int.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            return $"Triangle: \n" +
                $"Height: {_height} \n" +
                $"Fill: {_isFilled}, Fill with char: {fillWithChar}";
        }

        public override void createShape()
        {
            Console.WriteLine("Type height:");
            this.Height = int.Parse(Console.ReadLine());
        }
    }
}
