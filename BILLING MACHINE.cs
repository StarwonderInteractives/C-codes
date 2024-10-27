using System;

class BILLING_MACHINE
{
    static void Main()
    {
        int[] cod = new int[5];
        int[] price = new int[5];
        int[] qty = new int[5];
        int[] tc = new int[5];
        int s1 = 0, s2 = 0, s3 = 0;

        Console.WriteLine("ENTER CODE, PRICE AND QUANTITY");

        for (int i = 0; i < 5; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            cod[i] = int.Parse(input[0]);
            price[i] = int.Parse(input[1]);
            qty[i] = int.Parse(input[2]);
            s1 += price[i];
            s2 += qty[i];
            tc[i] = price[i] * qty[i];
            s3 += tc[i];
        }

        Console.WriteLine("CODE\tPRICE\tQTY\tTOTAL");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{cod[i]}\t{price[i]}\t{qty[i]}\t{tc[i]}");
        }

        Console.WriteLine("SUM OF PRICE: " + s1);
        Console.WriteLine("TOTAL ITEMS: " + s2);
        Console.WriteLine("SUM OF TOTAL: " + s3);
    }
}

