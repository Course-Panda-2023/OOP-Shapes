using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// class represents a parallelgram
    /// </summary>
    internal class Parallelogram : Shape
    {
        private const int Height = 7;

        private bool isFilled = true;

        public bool IsFilled
        {
            get { return isFilled; }
            set { isFilled = value; }
        }

        public void Draw()
        {
            Console.WriteLine("Parallelgram");
            for (int i = 0; i < Height; i++)
            {
                Console.Write(new string(' ', Height - i - 1));
                if (0 < i && i < Height - 1)
                {
                    Console.Write('#');
                    Console.Write(new string(isFilled ? '#' : ' ', Height - 2));
                    Console.Write('#');
                }
                else
                {
                    Console.Write(new string('#', Height));
                }
                
                
                Console.WriteLine();
            }
        }

        public bool GetIsFilled()
        {
            return isFilled;
        }

        public void SetIsFilled(bool isFilled)
        {
            this.isFilled = isFilled; 
        }
    }
}
