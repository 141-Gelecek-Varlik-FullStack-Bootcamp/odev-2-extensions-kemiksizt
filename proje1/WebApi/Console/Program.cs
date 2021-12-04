using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double amount = 15;

            Console.WriteLine(Extension.Extensions.toUSD(amount));
            Console.WriteLine(Extension.Extensions.GetCurrencies(Extension.Enum.CurrencyTypeDollar));
        }
    }
}
