using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.Notify += DisplayMessage;
            acc.Put(20);
            Console.WriteLine($"Balance: {acc.Sum}");
            acc.Take(70);
            Console.WriteLine($"Balance: {acc.Sum}");
            acc.Take(180);
            Console.WriteLine($"Balance: {acc.Sum}");
            Console.ReadKey();
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
