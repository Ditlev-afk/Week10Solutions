using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first integer");
        int first = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second integer");
        int second = int.Parse(Console.ReadLine());
        
        int sum = first + second;
        int product = first * second;
        int difference = first - second;
        int quotient = first / second;
        int remainder = first % second;

        Console.WriteLine("Result:");
        Console.WriteLine(sum);
        Console.WriteLine(product);
        Console.WriteLine(difference);
        Console.WriteLine(quotient);
        Console.WriteLine(remainder);
    }
}