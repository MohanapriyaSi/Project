using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transaction.API.Models
{
    public class TransactionDetails
    {
        [Key]
        public int TransactionId { get; set; }
        public DateTime DateRange { get; set; }
        public string Particulars { get; set; }
        public double? Wihtdraw { get; set; }
        public double? Deposit { get; set; }
        public double Balance { get; set; }
        public double? SavingsBalance { get; set; }
        public double? CurrentBalance { get; set; }
        public long CustomerId { get; set; }
        public ulong AccountId { get; set; }
        public double? Amount { get; set; }
    }
}
