
using System;

public class QuadraticEquationSolver
{
    public static void Main(string[] args)
    {
        // User input for coefficients a, b, c
        Console.Write("Enter the coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        // Calculating discriminant
        double discriminant = b * b - 4 * a * c;

        // Finding the nature of the roots and calculating the roots
        if (discriminant >= 0)
        {
            // Roots are real and different or real and same
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Roots are real.");
            Console.WriteLine($"Root 1: {root1:F2}");
            Console.WriteLine($"Root 2: {root2:F2}");
        }
        else
        {
            // Roots are imaginary
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("Roots are imaginary.");
            Console.WriteLine($"Root 1: {realPart:F2} + {imaginaryPart:F2}i");
            Console.WriteLine($"Root 2: {realPart:F2} - {imaginaryPart:F2}i");
        }
    }
}
