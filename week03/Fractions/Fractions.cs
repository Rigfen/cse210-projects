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

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public string GetDecimalValue()
    {
        double decimalValue = (double)_top / _bottom;
        return decimalValue.ToString();
    }
}