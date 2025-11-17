using System;

class Program
{
    static Main()
    {
        Console.WriteLine("Enter an integer");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}