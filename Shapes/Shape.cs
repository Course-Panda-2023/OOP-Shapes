using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        protected bool fill;
        public bool Fill
        {
            set { fill = value; }
        }
        protected char fillWithChar;
        public char FillWithChar
        {
            set { fillWithChar = value; }
        }

        public Shape()
        {
            this.fill = true;
            this.fillWithChar = '#';
        }

        public abstract void print();
        public abstract void update();
    }
}
