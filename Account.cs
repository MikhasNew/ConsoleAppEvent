using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvent
{
    public class Account : IAccount
    {
        public decimal Sum { get; private set; }

        public int AccauntID { get; private set; }

        public AccountTips AccountTip { get; private set; }

        public IClient Client { get; private set; }

        public event IAccount.AccountHandler AccountReplenishmentNotify;
        public event IAccount.AccountHandler AccountDebitingNotify;

        public Account(decimal sum,  person)
        {
            Sum = sum;
            Person = person;
            SetAccountTip(sum);
            Console.WriteLine($"Bank Message: Dear client, thank you for opening an account {AccountTip}" +
                " with our bank. You will be credited with a bonus according to your account type.");
            SetBonus(AccountTip);

        }
        void SetBonus(AccountTips tip)
        {
            switch (tip)
            {
                case AccountTips.Gold:
                    Put(Sum*0.05m);
                    break;
                case AccountTips.Silver:
                    Put(Sum * 0.03m); 
                    break;
                default:
                    Put(Sum * 0.01m); ;
                    break;
            }
        }
        public void Put(decimal sum)
        {
            Sum += sum;
            AccountReplenishmentNotify?.Invoke(this, new AccountEventArgs($"The account received {sum}", sum));
        }

        public void Take(decimal sum)
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

        public void SetAccountTip(decimal sum)
        {
            switch(sum)
            {
                case > 5000: AccountTip = AccountTips.Gold;
                    break;
                case > 3000: AccountTip = AccountTips.Silver;
                    break;
                default: AccountTip = AccountTips.Base;
                    break;
            }
        }

    }
}


