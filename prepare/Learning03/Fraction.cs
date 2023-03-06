class Fraction
{

    private int _numerator;
    private int _denomenator;

    public Fraction()
    {
        _numerator = 1;
        _denomenator = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denomenator = 1;
    }

    public Fraction(int numerator, int denomenator)
    {
        _numerator = numerator;
        _denomenator = denomenator;
    }

    public int GetTop()
    {
        return _numerator;
    }

    public void SetTop(int numerator)
    {
        _numerator = numerator;
    }

    public int GetBottom()
    {
        return _denomenator;
    }

    public void SetBottom(int denomenator)
    {
        _denomenator = denomenator;
    }

    public string GetFractionString()
    {
        return ($"{_numerator}/{_denomenator}");
    }

    public double GetDecimalValue()
    {
        return  (double)_numerator / (double)_denomenator;
    }
}