using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction no_input = new Fraction();
        Fraction whole_number = new Fraction (5);
        Fraction test_one = new Fraction(3, 4);
        Fraction test_two = new Fraction (1, 3);

        Console.WriteLine(no_input.GetFracString());
        Console.WriteLine(no_input.GetFracDecimal());
        Console.WriteLine();
        Console.WriteLine(whole_number.GetFracString());
        Console.WriteLine(whole_number.GetFracDecimal());
        Console.WriteLine();
        Console.WriteLine(test_one.GetFracString());
        Console.WriteLine(test_one.GetFracDecimal());
        Console.WriteLine();
        Console.WriteLine(test_two.GetFracString());
        Console.WriteLine(test_two.GetFracDecimal());
    }
}