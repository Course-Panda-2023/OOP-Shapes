public class Trapeze: Shape{
    public Trapeze(bool fill, char representingChar, int verticalLength, int horizontalLength): 
        base(fill, representingChar, verticalLength, horizontalLength){

    }
    
    protected override bool IsExternal(int i, int j)
    {
        if (j <= this.HorizontalLength / 2)
        {
            return false;
        }
        else
        {
            return (j - this.HorizontalLength / 2) > i;
        }
    }

    protected override bool IsInternal(int i, int j)
    {
        if (j <= this.HorizontalLength / 2)
        {
            if ((i == 0) || (i == this.VerticalLength - 1) || (j == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            if (i == this.VerticalLength - 1)
            {
                return false;
            }
            else
            {
                return (j - this.HorizontalLength / 2) < i;
            }
        }
    }
}