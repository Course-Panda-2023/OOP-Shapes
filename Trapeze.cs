using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIShape
{
    internal class Trapeze : Shape
    {
        int trapezeTop , trapezeBase , trapezeHeight;
        public Trapeze(bool fillIn, char idChar,int trapezeHeight,int trapezeBase,int trapezeTop) : base(fillIn, idChar)
        {
            this.trapezeBase= trapezeBase;
            this.trapezeHeight= trapezeHeight;
            this.trapezeTop= trapezeTop;
        }

        public override void PrintFill()
        {
            int height = trapezeHeight; // The height of the trapezoid
            int baseLength = trapezeBase; // The length of the bottom base of the trapezoid
            int topLength = trapezeTop; // The length of the top base of the trapezoid

            // Iterate over each row of the trapezoid
            for (int row = 0; row < height; row++)
            {
                // Calculate the length of the current row
                int currentLength = baseLength - (int)((double)row / (double)(height - 1) * (baseLength - topLength));

                // Print spaces before the trapezoid to align it in the console
                Console.Write(new string(' ', (baseLength - currentLength) / 2));

                // Print the trapezoid for the current row
                Console.Write(new string('#', currentLength));

                // Start a new line for the next row
                Console.WriteLine();
            }
        }

        public override void PrintNoFill()
        {
            int height = trapezeHeight; // The height of the trapezoid
            int baseLength = trapezeBase; // The length of the bottom base of the trapezoid
            int topLength = trapezeTop; // The length of the top base of the trapezoid

            // Iterate over each row of the trapezoid
            for (int row = 0; row < height; row++)
            {
                
                // Calculate the length of the current row
                int currentLength = baseLength - (int)((double)row / (double)(height - 1) * (baseLength - topLength));

                // Print spaces before the trapezoid to align it in the console
                Console.Write(new string(' ', (baseLength - currentLength) / 2));

                if(row== 0||row==height-1)
                    Console.Write(new string('#', currentLength));
                else
                    Console.Write("#" + new string(' ', currentLength - 2) + "#");


                // Print the trapezoid for the current row

                // Start a new line for the next row
                Console.WriteLine();
            }
        }
    }
}
