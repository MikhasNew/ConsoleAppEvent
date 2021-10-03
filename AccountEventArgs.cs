using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvent
{
    public class AccountEventArgs
    {
        public string Message { get; }
        public decimal Sum { get; }

        public AccountEventArgs(string mes, decimal sum)
        {
            Message = mes;
            Sum = sum;
        }
    }
}
