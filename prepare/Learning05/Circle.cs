using System;

public class Circle : Shape
{
    private double _radius;
    private double Radius
    {
        get {return _radius;}
        set {_radius = value;}
    }
    public double GetArea()
    {
        Radius = 5;
        double area = Math.PI * Radius * Radius;
        return area;
    }
    public string GetColor()
    {
        ShapeColor = "Yellow";
        return ShapeColor;
    }
}