using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Customer.API.Models
{
    public class CustomerDetails
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
