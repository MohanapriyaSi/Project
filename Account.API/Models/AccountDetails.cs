using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Account.API.Models
{
    public class AccountDetails
    {
        [Key]
        public int recordId { get; set; }
        public int CustomerId { get; set; }
        public ulong CurrentAccountId { get; set; }
        public ulong SavingsAccountId { get; set; }
        public double CurrentBalance { get; set; }
        public double SavingsBalance { get; set; }
        public double TotalAccountBalance { get; set; }
        
    }
}
