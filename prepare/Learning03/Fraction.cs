using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction (int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction (int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public string GetFracString()
    {
        string fraction_string = $"{_numerator}/{_denominator}";
        return fraction_string;
    }

    public double GetFracDecimal()
    {
        double fraction_decimal = (double)_numerator / (double)_denominator;
        return fraction_decimal;
    }

}