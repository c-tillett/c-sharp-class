using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Square square = new Square();
        List<Shape> shapes = new List<Shape>{circle, rectangle, square};
        for (int i = 0; i < shapes.Count(); i++)
        {
            string color = shapes[i].ShapeColor;
            double area = shapes[i].GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
        }
    }
}