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

    public Fraction (int top)
    {
        this._top =top;
        _bottom = 1;

    }

    public Fraction (int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;
    }

    public int GetTop()
    {
    return _top;
    }

    public int GetBottom()
    {
    return _bottom;
    }

    public void SetTop(int value)
    {
    _top = value;
    }

    public void SetBottom(int value)
    {
    _bottom = value;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}