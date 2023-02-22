using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Shape
    {
        private int height;
        public int Height
        {
            set
            {
                height = value;
            }
        }
        public Triangle() : base()
        {
            this.height = 3;
        }

        private void printSpaces(int amount)
        {
            for (int i = 0; i < amount; i++)
                Console.Write(' ');
        }

        public override void print()
        {
            int repeatChar = 1;
            for (int i = this.height - 1; i >= 0; i--)
            {
                printSpaces(i);
                for (int j = 0; j < repeatChar; j++)
                {
                    if (!this.fill && j != 0 && j != repeatChar - 1 && i != 0)
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
                this.height = int.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            return $"Triangle: \n" +
                $"Height: {height} \n" +
                $"Fill: {fill}, Fill with char: {fillWithChar}";
        }
    }
}
