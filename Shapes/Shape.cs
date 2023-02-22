using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected bool isFull;
        protected char representativeChar;

        public Shape (bool isFull, char representativeChar)
        {
            this.isFull = isFull;
            this.representativeChar = representativeChar;
        }

        public bool IsOutline(int i, int j, int width, int side)
        {
            return (i == 0 || j == 0 || j == width - 1 || i == side - 1);
        }

        public abstract void PrintShape();
        public abstract void PrintFullShape();
        public abstract void PrintEmptyShape();
        public abstract void Update(bool full, char representativeChar, int heigth, int width);
        public void UpdateFull(bool full)
        {
            this.isFull = full;
        }
        public void UpdateRepChar(char representativeChar)
        {
            this.representativeChar = representativeChar;
        }
        public abstract void Updateheigth(int heigth);
        public abstract void UpdateWidth(int width);

    }
}
