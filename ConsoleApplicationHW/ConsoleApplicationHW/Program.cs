using System;

namespace ConsoleApplicationHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //customer input
            Console.WriteLine("Please input the nominal of the trade:");
            double nominal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the price of the trade:");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input transaction type:");
            string userInput = Console.ReadLine();
            TransactionType trType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            //calculating and showing the result
            double currentValue = trType == TransactionType.Buy ? nominal * price : (-1) * nominal * price;
            Console.WriteLine($"Current value of the trade is: {currentValue}");
            Console.ReadLine();
        }
    }
}
