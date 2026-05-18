using System;

class Program

{
    static void Main(string[] args)
    {
       Fraction f1 = new Fraction();
       Fraction f2 = new Fraction(6);
       Fraction f3 = new Fraction(6, 7);

       Console.WriteLine($"Fraction 1: {f1.GetFractionString()}");
       Console.WriteLine($"Fraction 2: {f2.GetFractionString()}");
       Console.WriteLine($"Fraction 3: {f3.GetFractionString()}");

       Console.WriteLine($"Decimal value of Fraction 3: {f3.GetDecimalValue()}");
    
       f3.SetTop(10);
       f3.SetBottom(2);

       Console.WriteLine(f3.GetTop());
       Console.WriteLine(f3.GetBottom());
       Console.WriteLine(f3.GetFractionString());
       Console.WriteLine(f3.GetDecimalValue());
    
    }
}