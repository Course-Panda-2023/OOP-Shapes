using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        protected bool _isFilled;
        public bool Fill
        {
            set { _isFilled = value; }
        }
        protected char fillWithChar;
        public char FillWithChar
        {
            set { fillWithChar = value; }
        }

        public Shape()
        {
            this._isFilled = true;
            this.fillWithChar = '#';
        }

        public abstract void print();
        public abstract void update();
        public abstract void createShape();
    }
}
