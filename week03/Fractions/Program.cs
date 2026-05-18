using System;

class Program

{
    static void Main(string[] args)
    {
       Fraction f1 = new Fraction();
       Fraction f2 = new Fraction(5);
       Fraction f3 = new Fraction(3, 4);

       Console.WriteLine($"Fraction 1: {f1.GetFractionString()}");
       Console.WriteLine($"Fraction 2: {f2.GetFractionString()}");
       Console.WriteLine($"Fraction 3: {f3.GetFractionString()}");

       Console.WriteLine($"Decimal value of Fraction 1: {f1.GetDecimalValue()}");
       Console.WriteLine($"Decimal value of Fraction 2: {f2.GetDecimalValue()}");
       Console.WriteLine($"Decimal value of Fraction 3: {f3.GetDecimalValue()}");
    }
}