using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvent
{
    public class Account : IAccount
    {
        public int Sum { get; private set; }
        public event IAccount.AccountHandler AccountReplenishmentNotify;
        public event IAccount.AccountHandler AccountDebitingNotify;

        public Account(int sum)
        {
            Sum = sum;
        }

        public void Put(int sum)
        {
            Sum += sum;
            AccountReplenishmentNotify?.Invoke(this, new AccountEventArgs($"The account received {sum}", sum));
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                AccountDebitingNotify?.Invoke(this, new AccountEventArgs($"The amount {sum} has been withdrawn from the account", sum));
            }
            else
            {
                AccountDebitingNotify?.Invoke(this, new AccountEventArgs("Not enough money in the account", sum)); ;
            }
        }
    }
}


