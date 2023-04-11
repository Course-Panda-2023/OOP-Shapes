using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Rectangle : Shape
    {
        protected int height;
        protected int width;

        public Rectangle(int _height, int _width) //: base(_fill)
        {
            height = _height;
            width = _width;
        }

        internal static Rectangle Create()
        {
            Console.WriteLine("enter height [1,30] :");
            int h = CLIwrapper.ReadIntInput(1, 30);
            Console.WriteLine("enter width [1,30] :");
            int w = CLIwrapper.ReadIntInput(1, 30);
            return new Rectangle(h, w);
        }
        protected override void EditSpecific(string paramName, string paramValue)
        {
            switch (paramName)
            {
                case "height":
                    height = Int32.Parse(paramValue);
                    break;
                case "width":
                    width = Int32.Parse(paramValue);
                    break;
                default:
                    Console.WriteLine("error in parameter name");
                    break;
            }
        }
        internal override void Draw()
        {
            Console.WriteLine();
            if (fill||height<=2)
                for (int i = 0; i < height; i++)
                    DrawLine(width, 1);
            else
            {
                DrawLine(width, 1);
                for (int i = 0; i < height-2; i++)
                    DrawLineEmpty(width, 1);
                DrawLine(width, 1);
            }
        }
        protected override string GetParams()
        {
            return $"height: {height} width: {width} ";
        }
    }
}
