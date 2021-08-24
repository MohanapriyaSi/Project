using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transaction.API.Models
{
    public class UserTransaction
    {
        [Key]
        public int recordId { get; set; }
        public int CustomerId { get; set; }
        public ulong CurrentAccountId { get; set; }
        public ulong SavingsAccountId { get; set; }
        public double? CurrentBalance { get; set; }
        public double? SavingsBalance { get; set; }
        public double? TotalAccountBalance { get; set; }
    }
}
