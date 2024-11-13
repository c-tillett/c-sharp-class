using System;

public abstract class Shape
{
    private string _color;
    public string ShapeColor
    {
        get {return _color;}
        set {_color = value;}
    }

    public virtual double GetArea()
    {
        double area = 0;
        return area;
    }
}