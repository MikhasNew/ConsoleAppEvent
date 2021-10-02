using System;

namespace ConsoleAppEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new(100);
            acc.AccountReplenishmentNotify += DisplayMessage;
            acc.AccountDebitingNotify += DisplayMessage;
            acc.Put(1000);
            acc.Take(700);
            acc.Take(410);
            Console.Read();
        }

        private static void DisplayMessage(object sender, AccountEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
