using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Diamond : Shape
    {
        private int width;
        private int height;

        public Diamond(int _width, int _height)
        {
            width = _width;
            height = _height;
        }

        internal static Diamond Create()
        {
            Console.WriteLine("enter width [1,30] :");
            int w = CLIwrapper.ReadIntInput(1, 30);
            Console.WriteLine("enter height [1,30] :");
            int h = CLIwrapper.ReadIntInput(1, 30);
            return new Diamond(w,h);
        }

        protected override void EditSpecific(string paramName, string paramValue)
        {
            switch(paramName)
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

        protected override string GetParams()
        {
            return $"height: {height} width: {width} ";
        }

        internal override void Draw()
        {
            int halfCeiling=(height+1)/2;
            Console.WriteLine();
            for (int i = halfCeiling - 1; i >= 0; i--)
            {
                double delta = ((double)i * ((double)width - 1.0) / halfCeiling);
                int len = (int)(width - delta);
                if (fill || i == halfCeiling- 1)
                    DrawLine(len, (int)((width - len) / 2));
                else
                    DrawLineEmpty(len, (int)((width - len) / 2));
            }
            int halfFloor = height / 2;
            for (int i = 0; i < halfFloor; i++)
            {
                double delta = ((double)i * ((double)width - 1.0) / halfFloor);
                int len = (int)(width - delta);
                if (fill || i == halfFloor-1)
                    DrawLine(len, (int)((width - len) / 2));
                else
                    DrawLineEmpty(len, (int)((width - len) / 2));
            }

        }
    }
}
