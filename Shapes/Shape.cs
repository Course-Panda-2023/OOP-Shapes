namespace Shapes
{
    public abstract class Shape
    {
        protected Shape(bool isFilled, char sign)
        {

            this.IsFilled = isFilled;
            this.Sign = sign;
        }

        public bool IsFilled;
        public char Sign;
        public void Print()
        {
            if (this.IsFilled)
            {
                PrintFilled();
            }
            else
            {
                PrintNonFilled();
            }
        }
        protected abstract void PrintNonFilled();
        protected abstract void PrintFilled();
        public abstract void Update(Dictionary<string, int> parameters, bool isFilled, char sign);
    }
}
