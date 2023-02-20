using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Trapezoid : Shape
    {
        private int _upperBase;
        public int UpperBase
        {
            set { _upperBase = value; }
        }
        private int _height;
        
        public int Height
        {
            set { _height = value; }
        }
        public Trapezoid() : base()
        {
            this._upperBase = 3;
            this._height = 2;
        }

        private void printSpaces(int amount)
        {
            for (int i = 0; i < amount; i++)
                Console.Write(' ');
        }

        public override void print()
        {
            int repeatChar = this._upperBase;
            for (int i = this._height; i >= 0; i--)
            {
                printSpaces(i);
                for (int j = 0; j < repeatChar; j++)
                {
                    if (!fill && i != 0 && i != this._height && j > 0 && j < repeatChar -1)
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
            Console.WriteLine("Do you want to change the upper base? y/n");
            bool toChange = char.Parse(Console.ReadLine()).Equals('y') ? true : false;
            if (toChange)
            {
                Console.WriteLine("Type new upper base:");
                this._upperBase = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Do you want to change the height? y/n");
            toChange = char.Parse(Console.ReadLine()).Equals('y') ? true : false;
            if (toChange)
            {
                Console.WriteLine("Type new height:");
                this._height = int.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            return $"Trapezoid: \n" +
                $"Upper base: {_upperBase} \n" +
                $"Height: {_height} \n" +
                $"Fill: {fill}, Fill with char: {fillWithChar}";
        }
    }
}
