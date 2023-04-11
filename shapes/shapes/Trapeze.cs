using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Trapeze : Shape
    {
        int bottom_width, top_width, height;
        public Trapeze(int _bottom_width, int _top_width, int _height)
        {
            height = _height;
            bottom_width = _bottom_width;
            top_width= _top_width;
        }

        internal static Trapeze Create()
        {
            Console.WriteLine("enter height [1,30] :");
            int h = CLIwrapper.ReadIntInput(1, 30);
            Console.WriteLine("enter bottom width [1,30] :");
            int w1 = CLIwrapper.ReadIntInput(1, 30);
            Console.WriteLine("enter top width [1,30] :");
            int w2 = CLIwrapper.ReadIntInput(1, 30);
            return new Trapeze(w1, w2, h);
        }
        protected override void EditSpecific(string paramName, string paramValue)
        {
            switch (paramName)
            {
                case "height":
                    height = Int32.Parse(paramValue);
                    break;
                case "top":
                    top_width = Int32.Parse(paramValue);
                    break;
                case "bottom":
                    top_width = Int32.Parse(paramValue);
                    break;
                default:
                    Console.WriteLine("error in parameter name. Trapeze params are: height, top, bottom");
                    break;
            }
        }
        protected override string GetParams()
        {
            return $"height: {height} width: [top: {top_width},bottom: {bottom_width}] ";
        }

        internal override void Draw()
        {
            int width = Math.Abs(bottom_width - top_width);
            int wideBase = (bottom_width > top_width) ? 1 : -1;
            Console.WriteLine();
            for (int i = height - 1; i >= 0; i--)
            {
                double delta = ((double)i * ((double)width - 1.0) / height);
                int len = (i == height - 1) ? 0 : (int)(width - delta) * wideBase;
                if (fill || i == height - 1 || i == 0)
                    DrawLine(len + top_width, (int)((width - len) / 2));
                else
                    DrawLineEmpty(len + top_width, (int)((width - len) / 2));
            }
        }
    }
}
