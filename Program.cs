using System;

namespace ConsoleAppEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Eebbiill", 1111111);
            Account account = new Account(4500, bill);
            bill.AddAccount(account);



            //Account acc = new(100, new Person("Bill", "Eebbiill",1111111));
            //acc.AccountReplenishmentNotify += DisplayMessage;
            //acc.AccountDebitingNotify += DisplayMessage;
            //acc.Put(1000);
            //acc.Take(700);
            //acc.Take(410);
            //Console.Read();
        }

        private static void DisplayMessage(object sender, AccountEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
