

public abstract class Shape{
    private bool _fill = false;
    private char _representingChar = '#';
    protected int VerticalLength;
    protected int HorizontalLength;

    protected Shape(bool fill, char representingChar, int verticalLength, int horizontalLength){
        this._fill = fill;
        this._representingChar = representingChar;
        this.VerticalLength = verticalLength;
        this.HorizontalLength = horizontalLength;
    }

    protected abstract bool IsInternal(int i, int j);
    protected abstract bool IsExternal(int i, int j);

    protected bool IsOnEdge(int i, int j)
    {
        return ((! IsInternal(i, j)) && (! IsExternal(i, j)));
    }

    public void Print(){
        for (int i=0; i < VerticalLength; i++){
            if (i != 0)
            {
                Console.WriteLine();
            }
            
            for (int j=0; j < HorizontalLength; j++)
            {
                if (IsExternal(i, j))
                {
                    Console.Write(' ');
                }
                else
                {
                    if (_fill){
                        Console.Write(_representingChar);
                    } else {
                        if (! this.IsInternal(i, j)){
                            Console.Write(_representingChar);
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }
            }
        }
        
        Console.WriteLine();
    }
}