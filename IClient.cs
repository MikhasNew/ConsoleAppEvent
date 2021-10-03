using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvent
{
    public interface IClient
    {
        //delegate void AccountHandler(object sender, AccountEventArgs e);
        //event AccountHandler AccountReplenishmentNotify;
        //event AccountHandler AccountDebitingNotify;

        string Name { get;}
        string LastName { get; }
        int PersonalID { get; }
        IAccount Account { get; }



    }
}
