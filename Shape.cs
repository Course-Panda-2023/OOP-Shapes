


using System.Data;

abstract class Shape
{
    public bool FillShape {get; set;}
    public char Char {get; set;}
    public Shape(bool FillShape, char Char)
    {
        this.FillShape = FillShape;
        this.Char = Char;
    }

    public abstract void PrintShape();
    
    public abstract void UpdateShape();

    public override string ToString(){return "";}


}