using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Square : Rectangle
    {

        public Square(int _length) : base(_length, _length) { }
        internal static new Square Create()
        {
            Console.WriteLine("enter length [1,30] :");
            int l = CLIwrapper.ReadIntInput(1, 30);
            return new Square(l);
        }
        protected override string GetParams()
        {
            return $"length:{width} ";
        }
        protected override void EditSpecific(string paramName, string paramValue)
        {
            switch (paramName)
            {
                case "length":
                    height = Int32.Parse(paramValue);
                    width = Int32.Parse(paramValue);
                    break;
                default:
                    Console.WriteLine("error in parameter name");
                    break;
            }
        }
    }
}
