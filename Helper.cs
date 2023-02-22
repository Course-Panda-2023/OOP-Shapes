using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    internal class Helper
    {
        public static void printList(List<Shape> shapesList)
        {
            int index = 1;
            foreach (Shape shape in shapesList)
            {
                Console.WriteLine("Shape " + index + ". :  " + shape.GetType().Name + " " + shape.ToString());
                index++;
            }
        }
    }
}
