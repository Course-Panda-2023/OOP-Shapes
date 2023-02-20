using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresProject
{
    internal class Circle : Figures
    {
        private int radius;
        public Circle(int radius, bool isFilled, char figurePoint) : base(isFilled, figurePoint)
        {
            this.radius = radius;
        }
        public Circle(int radius)
        {
            this.radius = radius;
        }

        //TODO: Implement the Draw() method which gets the raduius of the circle, and isFilled variable and draws the circle.
        //if isFilled true - draw the circle with the figurePoint character and fill it with the figurePoint character
        //if false - draw the circle with the figurePoint character and fill it with the space character
        public override void Draw()
        {
            for (int i = 0; i <= 2 * radius; i++)
            {
                for (int j = 0; j <= 2 * radius; j++)
                {
                    double distance = Math.Sqrt((i - radius) * (i - radius) + (j - radius) * (j - radius));
                    if (distance > radius - 0.5 && distance < radius + 0.5)
                    {
                        if (isFilled)
                        {
                            Console.Write(figurePoint);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        
        
            
        


    }
}
