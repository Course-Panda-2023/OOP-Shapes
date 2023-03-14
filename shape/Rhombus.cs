
public class Rhombus: Shape{
    public Rhombus(bool fill, char representingChar, int verticalLength, int horizontalLength): 
        base(fill, representingChar, verticalLength, horizontalLength){

    }

    protected override bool IsInternal(int i, int j)
    {
        if (j <= this.HorizontalLength / 2)
        {
            if (i <= this.VerticalLength / 2)
            {
                return i > j;
            }
            else
            {
                return i - this.VerticalLength / 2 < j;
            }
        }
        else
        {
            if (i <= this.VerticalLength / 2)
            {
                return i < j - this.HorizontalLength / 2;
            }
            else
            {
                return i - this.VerticalLength / 2 < j - this.HorizontalLength / 2;
            }
        }
    }

    protected override bool IsExternal(int i, int j)
    {
        if (j <= this.HorizontalLength / 2)
        {
            if (i <= this.VerticalLength / 2)
            {
                return i <= j;
            }
            else
            {
                return i - this.VerticalLength / 2 > j;
            }
        }
        else
        {
            if (i <= this.VerticalLength / 2)
            {
                return i > j - this.HorizontalLength / 2;
            }
            else
            {
                return i - this.VerticalLength / 2 > j - this.HorizontalLength / 2;
            }
        }
    }
}