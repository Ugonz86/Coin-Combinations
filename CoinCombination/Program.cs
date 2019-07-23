using System;
using CoinCombination.Models;

class Program
{
    private static void Main()
    {
        Console.WriteLine("Welcome to the Coin Slide!");
        Console.WriteLine("Please enter your change amount in cents: ");
        string coinInput = Console.ReadLine();
        int intInput = int.Parse(coinInput);

        CoinSlide.GetCoins(intInput);
        Console.WriteLine($"Your coin input is \"{coinInput}\" which equals to: ");
        Console.WriteLine($"\"{CoinSlide.numQuarters}\" quarters.");
        Console.Write($"\"{CoinSlide.numDimes}\" dimes.");
        Console.Write($"\"{CoinSlide.numNickels}\" nickels.");
        Console.Write($"\"{CoinSlide.numPennies}\" pennies.");

        Main();

    }
}
