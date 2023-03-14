
public class Triangular: Shape{
    public Triangular(bool fill, char representingChar, int verticalLength, int horizontalLength): 
        base(fill, representingChar, verticalLength, horizontalLength){

    }

    protected override bool IsInternal(int i, int j){
        return (j > 0) && (i != this.VerticalLength - 1) && (i < j);
    }
    
    protected override bool IsExternal(int i, int j){
        return (j > i);
    }
}