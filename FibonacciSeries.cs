using System;

public class FibonacciSeries
{
    public static void Main(string[] args)
    {
        // Input the number of terms for the Fibonacci series
        Console.Write("Enter the number of terms for the Fibonacci series: ");
        int numTerms = int.Parse(Console.ReadLine());

        // Display the Fibonacci series
        Console.WriteLine("Fibonacci Series:");
        DisplayFibonacciSeries(numTerms);
    }

    // Method to display the Fibonacci series
    private static void DisplayFibonacciSeries(int numTerms)
    {
        int firstTerm = 0, secondTerm = 1;

        for (int i = 0; i < numTerms; i++)
        {
            Console.Write(firstTerm + " ");

            // Calculate the next term by adding the previous two terms
            int nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}
