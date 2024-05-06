using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction= new Fraction(3, 4);
        Console.WriteLine(fraction.GetTopNum());
        Console.WriteLine(fraction.GetBottomNum());
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction.SetTopNum(5);
        fraction.SetBottomNum(6);
        
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

    }
}