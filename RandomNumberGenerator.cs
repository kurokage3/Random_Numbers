using System;
using System.Threading;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                PrintRandomNumbers();
                Thread.Sleep(5000);
            }
        }

        static void PrintRandomNumbers()
        {
            Random random = new Random();

            string coin = random.Next(0, 2) == 0 ? "Heads" : "Tails";
            Console.WriteLine($"Coin: {coin}");

            int d4 = random.Next(1, 5);
            Console.WriteLine($"D4 -> {d4}");

            int d6 = random.Next(1, 7);
            Console.WriteLine($"D6 -> {d6}");

            int d8 = random.Next(1, 9);
            Console.WriteLine($"D8 -> {d8}");

            int d10 = random.Next(1, 11);
            Console.WriteLine($"D10 -> {d10}");

            int d20 = random.Next(1, 21);
            Console.WriteLine($"D20 -> {d20}");
        }
    }
}
