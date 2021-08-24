using Customer.API.Context;
using Customer.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Customer.API.Repository;

namespace Customer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDetails>>> GetCustomers()
        {
            List<CustomerDetails> Customer = CustomerRepository.GetData();
            return Customer;
        }

        [HttpGet("/{CustId}")]
        public IEnumerable<CustomerDetails> GetcustomerByID(int CustId)
        {
            List<CustomerDetails> Customer = CustomerRepository.GetData();
            List<CustomerDetails> Cus = new List<CustomerDetails>();
            CustomerDetails acc = Customer.FirstOrDefault(a => a.CustomerId == CustId);
            Cus.Add(acc);
            return Cus;
        }

        [HttpPost]
        public async Task<ActionResult<CustomerDetails>> AddCustomer(CustomerDetails customer)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                CustomerRepository.TransactionsData(customer);
                List<CustomerDetails> Customer = CustomerRepository.GetData();
                var b = Customer.Max(p => p.CustomerId);
                customer.CustomerId = b;
                return customer;
                
            }           

        }

    }
}
