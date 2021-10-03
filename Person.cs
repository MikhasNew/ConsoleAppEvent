using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvent
{
    public class Person: IClient
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int PersonalID { get; private set; }
        public Account Account {get; private set;}

        IAccount IClient.Account => throw new NotImplementedException();

        public Person(string name, string lastname, int ID)
        {
            Name = name;
            LastName = lastname;
            PersonalID = ID;

        }
        public Person GetPerson()
        {
            return this;
        }
        public void AddAccount(Account account)
        {
            Account = account;
            Account.AccountDebitingNotify += Account_Notify;
            Account.AccountReplenishmentNotify += Account_Notify;
        }

        private void Account_Notify(object sender, AccountEventArgs e)
        {
            Console.WriteLine("Client message: "+e.Message);
        }

    }
}
