using System;

public class PythagoreanTriplet
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a natural number greater than 1: ");
        int m = int.Parse(Console.ReadLine());

        if (m > 1)
        {
            // Calculation
            int a = 2 * m;
            int b = m * m - 1;
            int c = m * m + 1;

            // Display
            Console.WriteLine($"The Pythagorean triplet for m = {m} is: {a}, {b}, {c}");
        }
        else
        {
            Console.WriteLine("The value of 'm' should be greater than 1.");
        }
    }
}
