using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal abstract class Shape
    {
        protected bool fill;
        char c;
        protected Shape(bool _fill = false ,char _c = '#')
        {
            fill = _fill;
            c = _c;
        }

        public void DrawLine(int length, int offset = 0)
        {
            Console.WriteLine((new string(' ',offset * 2) + new string(c , length)).Replace(c.ToString(), c.ToString() + " "));
        }
        public void DrawLineEmpty(int length, int offset = 0)
        {
            Console.WriteLine(new string(' ', offset * 2) + c + new string(' ', length * 2 - 3) + c);
        }
        internal abstract void Draw();
        public override string ToString()
        {
            string s1 = this.GetType().Name + " " + this.GetParams() + "fill:" + fill + " char:" + c;

            return s1;
        }

        protected abstract string GetParams();

        internal void Edit(string paramName, string paramValue)
        {
            if (paramName == "char")
            {
                c = paramValue.ToCharArray()[0];
                return;
            }
            if (paramName == "fill")
            {
                fill = bool.Parse(paramValue);
                return;
            }
            EditSpecific(paramName, paramValue);    
        }
        protected abstract void EditSpecific(string paramName, string paramValue);

    }
}
