using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailBankingSystemClient.Models
{
    public class Depositandwithdraw
    {
        public long AccountId { get; set; }
        public double Amount { get; set; }
        public string AccountType { get; set; }
        public string TransactionRequest { get; set; }
    }
}
