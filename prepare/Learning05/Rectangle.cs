using System;

public class Rectangle : Shape
{
    private double _firstSide;
    private double _secondSide;
    private double FirstSide
    {
        get {return _firstSide;}
        set {_firstSide = value;}
    }
    private double SecondSide
    {
        get {return _secondSide;}
        set {_secondSide = value;}
    }
    public double GetArea()
    {
        FirstSide = 5;
        SecondSide = 10;
        double area = FirstSide * SecondSide;
        return area;
    }
    public string GetColor()
    {
        ShapeColor = "orange";
        return ShapeColor;
    }
}