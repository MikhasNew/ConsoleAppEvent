using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvent
{
    public interface IAccount
    {
        delegate void AccountHandler(object sender, AccountEventArgs e);
        event AccountHandler AccountReplenishmentNotify;
        event AccountHandler AccountDebitingNotify;

        int Sum { get; }
        void Put(int sum);
        void Take(int sum);


    }
}
