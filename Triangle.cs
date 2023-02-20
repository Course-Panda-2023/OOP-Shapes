using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIShape
{
    internal class Triangle : Shape
    {
        int height;
        public Triangle(bool fillIn, char idChar,int height) : base(fillIn, idChar)
        {
            this.height = height;   
   
        }

        public override void PrintFill()
        {

            for (int i = 1; i <= height; i++)
            {
                // print spaces before each row
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                // print asterisks for the current row
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine(); // move to the next line
            }


        }

        public override void PrintNoFill()
        {

            // Print top of triangle
            for (int i = 0; i < height - 1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");

            // Print middle of triangle
            for (int i = 1; i < height - 1; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("#");
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
            }

            // Print bottom of triangle
            for (int i = 0; i < 2 * height - 1; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

        }

    }
}
