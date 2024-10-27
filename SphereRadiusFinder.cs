using System;

public class SphereRadiusFinder
{
    public static void Main(string[] args)
    {
        // User input for the volume of the sphere
        Console.Write("Enter the volume of the sphere: ");
        double volume = double.Parse(Console.ReadLine());

        // Calculate the radius
        double radius = Math.Cbrt(volume * (3.0 / 4.0) * (7.0 / 22.0));

        // Display
        Console.WriteLine($"The radius of the sphere is: {radius:F2}");
    }
}

