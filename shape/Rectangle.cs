
public class Rectangle: Shape{
    public Rectangle(bool fill, char representingChar, int verticalLength, int horizontalLength): 
        base(fill, representingChar, verticalLength, horizontalLength){

    }
    
    protected override bool IsExternal(int i, int j)
    {
        return false;
    }

    protected override bool IsInternal(int i, int j)
    {
        return ((i > 0) && (i < this.VerticalLength - 1)) && ((j > 0) && (j < this.HorizontalLength - 1));
    }
}