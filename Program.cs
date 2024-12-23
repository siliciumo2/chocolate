using System;

class Program
{
    static void Main()
    {
        int money = 15;
        int price = 1;
        int wrap = 3;

        int totalChocolates = CalculateMaxChocolates(money, price, wrap);

        Console.WriteLine($"Максимально возможное количество шоколадок: {totalChocolates}");
    }

    static int CalculateMaxChocolates(int money, int price, int wrap)
    {

        int chocolates = money / price;
        int wrappers = chocolates;


        while (wrappers >= wrap)
        {

            int newChocolates = wrappers / wrap;
            chocolates += newChocolates;
            wrappers = newChocolates + (wrappers % wrap);
        }

        return chocolates;
    }
}
