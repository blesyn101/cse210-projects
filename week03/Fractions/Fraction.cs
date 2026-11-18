public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // constructor with one parameter
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // constructor with parameters
    public Fraction(int top,int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

    
}