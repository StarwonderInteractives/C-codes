using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Calculator made in C#");

        double n1, n2;
        Console.WriteLine("Enter 1st number");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter 2nd number");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A to add");
        Console.WriteLine("S to subtract");
        Console.WriteLine("M to multiply");
        Console.WriteLine("D to divide");

        char ch = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (ch)
        {
            case 'A':
                Console.WriteLine(n1 + n2);
                break;

            case 'S':
                Console.WriteLine(n1 - n2);
                break;

            case 'M':
                Console.WriteLine(n1 * n2);
                break;

            case 'D':
                if (n2 != 0)
                    Console.WriteLine(n1 / n2);
                else
                    Console.WriteLine("Division by zero is not allowed.");
                break;

            default:
                Console.WriteLine("ERROR");
                break;
        }
    }
}
