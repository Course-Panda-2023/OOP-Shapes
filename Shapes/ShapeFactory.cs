using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// class reresents design pattern named factory to factorially create shapes 
    /// </summary>
    internal class ShapeFactory
    {
        /// <summary>
        /// hash set represents the names of the shapes that are available
        /// </summary>
        public HashSet<string> shapesNames = new HashSet<string>()
        {
            "Rectangle",
            "Square",
            "Triangle",
            "Rhombus",
            "Parallelgram",
            "Trapezium"
        };

        /// <summary>
        /// util function that check if two string are equal ignoring the case
        /// </summary>
        /// <param name="s1">a string</param>
        /// <param name="s2">another string</param>
        /// <returns></returns>
        private bool IsEqualIgnoreCases(string s1, string s2)
        {
            return string.Equals(s1, s2, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// factorially crreate a shape
        /// </summary>
        /// <param name="shapeType">a string of the name of the shape</param>
        /// <returns>the returned shape</returns>
        public Shape? GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (IsEqualIgnoreCases(shapeType, "RHOMBUS"))
            {
                return new Rhombus();
            }
            else if (IsEqualIgnoreCases(shapeType, "RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (IsEqualIgnoreCases(shapeType, "SQUARE"))
            {
                return new Square();
            }
            else if (IsEqualIgnoreCases(shapeType, "TRIANGLE"))
            {
                return new Triangle();
            }
            else if (IsEqualIgnoreCases(shapeType, "TRAPEZIUM"))
            {
                return new Trapezium(2, 10);
            }
            else if (IsEqualIgnoreCases(shapeType, "PARALLELGRAM"))
            {
                return new Parallelogram();
            }

            Console.WriteLine($"There is no shape type {shapeType}");
            return null;
        }
    }
}
