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

        int AccauntID { get; }
        AccountTips AccountTip {get;}
        IClient Client { get; }
        decimal Sum { get; }
        void Put(decimal sum);
        void Take(decimal sum);



    }
}
