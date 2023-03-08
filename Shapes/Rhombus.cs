using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rhombus : Shape
    {
        private int _halfMainHeight;
        public int HalfHeight
        {
            set { _halfMainHeight = value; }
        }

        public Rhombus() : base()
        {
            this._halfMainHeight = 3;
        }
        private void printSpaces(int amount)
        {
            for (int i = 0; i < amount; i++)
                Console.Write(' ');
        }

        public override void print()
        {
            int repeatChar = 1;
            for (int i = this._halfMainHeight - 1; i >= 0; i--)
            {
                printSpaces(i);
                for (int j = 0; j < repeatChar; j++)
                {
                    if (!this._isFilled && j != 0 && j != repeatChar - 1)
                        Console.Write(' ');
                    else
                        Console.Write(this.fillWithChar);
                }
                printSpaces(i);
                repeatChar += 2;
                Console.WriteLine();
            }
            repeatChar -= 4;
            for (int i = 1; i < this._halfMainHeight; i++)
            {
                printSpaces(i);
                for (int j = repeatChar - 1; j >= 0; j--)
                {
                    if (!this._isFilled && j != 0 && j != repeatChar - 1)
                        Console.Write(' ');
                    else
                        Console.Write(this.fillWithChar);
                }
                printSpaces(i);
                repeatChar -= 2;
                Console.WriteLine();
            }

        }

        public override void update()
        {
            Console.WriteLine("Do you want to change the height? y/n");
            bool toChange = char.Parse(Console.ReadLine()).Equals('y') ? true : false;
            if (toChange)
            {
                Console.WriteLine("Type new half height:");
                this._halfMainHeight = int.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            return $"Rhombus: \n" +
                $"half height: {this._halfMainHeight} \n" +
                $"Fill: {_isFilled}, Fill with char: {fillWithChar}";
        }

        public override void createShape()
        {
            Console.WriteLine("Type half height:");
            this.HalfHeight = int.Parse(Console.ReadLine());
        }
    }
}
