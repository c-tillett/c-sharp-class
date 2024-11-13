using System;

public class Square : Shape
{
    private double _side;
    private double SquareSide
    {
        get {return _side;}
        set {_side = value;}
    }
    public double GetArea()
    {
        SquareSide = 5;
        double area = SquareSide * SquareSide;
        return area;
    }
    public string GetColor()
    {
        ShapeColor = "red";
        return ShapeColor;
    }
}