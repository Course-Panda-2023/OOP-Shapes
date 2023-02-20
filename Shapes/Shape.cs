using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected bool full;
        protected char representativeChar;

        public Shape (bool full, char representativeChar)
        {
            this.full = full;
            this.representativeChar = representativeChar;
        }

        public abstract void PrintShape();
        public abstract void PrintFullShape();
        public abstract void PrintEmptyShape();
        public abstract void Update(bool full, char representativeChar, int heigth, int width);
    }
}
