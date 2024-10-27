using System;

public class NatureOfRootFinder
{
    public static void Main(string[] args)
    {
        // User input
        Console.Write("Enter the coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        // Calculating discriminant
        double discriminant = b * b - 4 * a * c;

        // Determining the nature of the roots
        if (discriminant >= 0)
        {
            Console.WriteLine("Roots are real.");

            // Calculate the roots
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            // Display the roots
            Console.WriteLine($"Root 1: {root1:F2}");
            Console.WriteLine($"Root 2: {root2:F2}");
        }
        else
        {
            Console.WriteLine("Roots are imaginary.");
        }
    }
}
