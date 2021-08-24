using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailBankingSystemClient.Models
{
    public class Account
    {
        [Key]
        public int recordId { get; set; }
        public int CustomerId { get; set; }
        public long CurrentAccountId { get; set; }
        public long SavingsAccountId { get; set; }
        public double CurrentBalance { get; set; }
        public double SavingsBalance { get; set; }
        public double TotalAccountBalance { get; set; }

    }
}
