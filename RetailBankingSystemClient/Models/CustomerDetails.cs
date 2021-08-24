using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailBankingSystemClient.Models
{
    public class CustomerDetails
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
        public DateTime DOB { get; set; }
        public long PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string PAN { get; set; }
        public long Aadhar { get; set; }
    }
}
