using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.API.Models
{
    public class DepositAndWithdraw
    {      
            public ulong AccountId { get; set; }
            public double Amount { get; set; }
            public string AccountType { get; set; }
            public string TransactionRequest { get; set; }
    }
}
