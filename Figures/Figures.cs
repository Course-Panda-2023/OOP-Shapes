using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresProject
{
    internal abstract class Figures
    {
        protected bool _isFilled;
        protected char _figurePoint;
        private static int counter = 0;
        protected readonly int _id;
        protected int _height;
        //static List<int> idList 
        public Figures()
        {
            this._isFilled = false;
            this._figurePoint = '#';
            addOneFigure();
            this._id = counter;
        }
        public Figures(bool _isFilled, char _figurePoint)
        {
            this._isFilled = _isFilled;
            this._figurePoint = _figurePoint;
            addOneFigure();
            this._id = counter;
        }
        public static void addOneFigure()
        {
            counter++;  
        }
        public static void removeOneFigure() {
            counter--;
        }
        
        public virtual void Draw()
        {
            return;
        }
        public char FigurePoint { get; set; }

        public int GetID()
        {
            return _id;
        }
        public static int getFiguresNum()
        {
             return counter;
        }
        public bool isFilled { get; set; }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public virtual string ToString()
        {
            return "Figure ID: " + _id + " isFilled: " + _isFilled + " figurePoint: " + _figurePoint;
        }
    }
}
