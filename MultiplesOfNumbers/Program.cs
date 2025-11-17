using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter dividend");
        double dividend = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter divisor");
        double divisor = double.Parse(Console.ReadLine());
        
        if (divisor == 0)
        {
            Console.WriteLine("Cannot divide by zero");
            return;
        }
        
        double remainder = dividend % divisor;
        
        if (Math.Abs(remainder) < 0.000001)
            Console.WriteLine("Multiples");
        else
            Console.WriteLine("Not multiples");
    }
}