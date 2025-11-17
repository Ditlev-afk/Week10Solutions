using System;

class Program
{
    static Main()
    {
        Console.WriteLine("Enter an integer");
        string input = Console.ReadLine();

        int sum = 0;
        
        foreach (char c in input)
        {
            if (int.TryParse(c.ToString(), out int digit))
            {
                sum += digit;
            }
        }

        Console.WriteLine($"Sum: {sum}");
    }
}