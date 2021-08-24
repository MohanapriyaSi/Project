using Account.API.Context;
using Account.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Account.API.Repository;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Account.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly HttpClient client = null;
        public AccountController(HttpClient client)
        {
            this.client = client;
        }
        [HttpGet("/{CustId}")]
        public IEnumerable<AccountDetails> GetAllAccounts(int CustId)
        {
            List<AccountDetails> accounts = new List<AccountDetails>();
            List<AccountDetails> Account = AccountRepository.GetData();
            AccountDetails acc = Account.FirstOrDefault(a=>a.CustomerId == CustId);
            accounts.Add(acc);
            return accounts;
        }

        [HttpGet("/Account/{AccountId}")]
        public IEnumerable<double> GetAccountsBalance(ulong AccountId)
        {
            List < AccountDetails > accounts = new List<AccountDetails>();
            List<double> bal = new List<double>();
            List<AccountDetails> Account = AccountRepository.GetData();

            var a = Account.Where(p => p.CurrentAccountId == AccountId).ToList();
            if(a.Count!=0)
            {
                return (from b in a select b.CurrentBalance).ToList();
            }
            else
            {
                var c = Account.Where(p => p.SavingsAccountId == AccountId).ToList();
                return (from b in c select b.SavingsBalance).ToList();
            }           

        }
        [HttpPost]
        [ActionName(name: "AddAccount")]
        public async Task<ActionResult<AccountDetails>> AddAccount(CustomerDetails customer)
        {
            int CustId = customer.CustomerId;
            AccountDetails account = null;
           ulong temp1 = (ulong)Guid.NewGuid().GetHashCode();
            ulong temp2 = (ulong)Guid.NewGuid().GetHashCode();
            if (CustId > 0 && ModelState.IsValid)
            {
                account = new AccountDetails { CustomerId=CustId, CurrentAccountId = temp1,SavingsAccountId = temp2,CurrentBalance = 0.0,SavingsBalance = 0.0};
                AccountRepository.TransactionsData(account);
              // await _context.SaveChangesAsync();
            }
            return account;
        }
        [HttpPost]
        [ActionName(name: "AddTransaction")]
        public async Task<ActionResult> AddTransaction([FromBody] DepositAndWithdraw obj)
        {
            List<AccountDetails> l = AccountRepository.GetData();
            AccountTransaction acc = new AccountTransaction();
            acc.AccountId = obj.AccountId;
            var result1 = l.Where(p => p.SavingsAccountId == obj.AccountId).ToList();
            var result2 = l.Where(p => p.CurrentAccountId == obj.AccountId).ToList();
            if(obj.TransactionRequest=="Deposit")
            {
                acc.Deposit = 1;
                acc.Wihtdraw = 0;
            }
            else
            {
                acc.Wihtdraw = 1;
                acc.Deposit = 0;
            }
            acc.Amount = obj.Amount;
            if (result1.Count != 0)
            {
                acc.SavingsBalance = result1[0].SavingsBalance;
                acc.CurrentBalance = 0;
                string jsonSerialObj = JsonSerializer.Serialize(acc);
                StringContent content = new StringContent(jsonSerialObj, Encoding.UTF8, "application/json");
                
                HttpResponseMessage response = await client.PostAsync("https://localhost:44336/api/Transaction/WithdrawAndDeposit", content);
                string Data = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                AccountTransaction data = System.Text.Json.JsonSerializer.Deserialize<AccountTransaction>(Data, options);
                l.Remove(result1[0]);
                result1[0].SavingsBalance = data.SavingsBalance;
                AccountRepository.TransactionsData(result1[0]);
                return StatusCode(200, "Transaction Successful!!");
            }
            else if (result2.Count != 0)
            {
                acc.CurrentBalance = obj.Amount;
                acc.SavingsBalance = 0;
                string jsonSerialObj = JsonSerializer.Serialize(acc);
                StringContent content = new StringContent(jsonSerialObj, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("https://localhost:44336/api/Transaction/WithdrawAndDeposit", content);
                string Data = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                AccountTransaction data = System.Text.Json.JsonSerializer.Deserialize<AccountTransaction>(Data, options);
                l.Remove(result2[0]);
                result2[0].CurrentBalance = data.CurrentBalance;
                AccountRepository.TransactionsData(result2[0]);
                return StatusCode(200, "Transaction Successful!!");
            }
            else
            {
                return StatusCode(500, "Invalid Account Id");
            }
        }

        }

 }
