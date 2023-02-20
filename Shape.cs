using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CLIShape
{
    internal abstract class Shape
    {
        protected bool fillIn;
        protected char idChar;
        public bool FillIn { get { return fillIn;} set { fillIn = value; } }
        public char IdChar { get { return idChar; } set { idChar = value; } }


        public Shape(bool fillIn, char idChar)
        {
            this.fillIn = fillIn;
            this.idChar = idChar;
        }
        
        public static List<string> Getproperties(string shap)
        {
            switch (shap)
            {

                case "square":
                    return new List<string>() {"edge"};

                case "rectangle":
                    return new List<string>() { "height", "width" };

                case "triangle":
                    return new List<string>() { "height" };

                case "rhombus":
                    return new List<string>() { "diagonal" };

                case "trapeze":
                    return new List<string>() { "trapezeTop", "trapezeBase", "trapezeHeight" };

                default:
                    return new List<string>();
            }
        }
        public void Print()
        {
            if (fillIn)
                PrintFill();
            else
                PrintNoFill();
        }
        public abstract void PrintNoFill();
        public abstract void PrintFill();
    }
}
