using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transaction.API.Models;
using Transaction.API.Context;
using Microsoft.EntityFrameworkCore;
using Transaction.API.Repository;
namespace Transaction.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
       static List<UserTransaction> userTransaction = TransactionRepository.AccountData();
        [HttpGet]
        public List<TransactionDetails> GetCustomers()
        {
            return TransactionRepository.GetData();
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        [ActionName(name: "WithdrawAndDeposit")]
        public async Task<ActionResult<TransactionDetails>> WithdrawAndDeposit([FromBody] TransactionDetails depositAndWithdraw)
        {
            TransactionDetails Ltransaction = new TransactionDetails();

            DepositAndWithdraw dw = new DepositAndWithdraw();

            if (depositAndWithdraw.Wihtdraw==1)
            {
                if (depositAndWithdraw.SavingsBalance!=0)
                {

                    Ltransaction.DateRange = DateTime.Now;
                    Ltransaction.Particulars = (depositAndWithdraw.AccountId).ToString() + "Withdraw";
                    Ltransaction.Wihtdraw = depositAndWithdraw.Amount;
                    Ltransaction.Deposit = null;
                    Ltransaction.Balance = 0.0;
                   // var x = (from b in depositAndWithdraw select b.SavingsBalance);
                    //double r = Convert.ToDouble(x);
                    Ltransaction.SavingsBalance = depositAndWithdraw.SavingsBalance - depositAndWithdraw.Amount;
                    Ltransaction.CurrentBalance = 0.0;
                    Ltransaction.CustomerId = 1;
                    TransactionRepository.TransactionsData(Ltransaction);
                    return Ltransaction;
                }
                else
                {
                    Ltransaction.DateRange = DateTime.Now;
                    Ltransaction.Particulars = (depositAndWithdraw.AccountId).ToString() + "Withdraw";
                    Ltransaction.Wihtdraw = depositAndWithdraw.Amount;
                    Ltransaction.Deposit = null;
                   // var x = (from b in result2 select b.CurrentBalance);
                    //double r = Convert.ToDouble(x);
                    Ltransaction.Balance = 0.0;
                    Ltransaction.SavingsBalance = 0.0;
                    Ltransaction.CurrentBalance = depositAndWithdraw.CurrentBalance - depositAndWithdraw.Amount;
                    Ltransaction.CustomerId = 1;
                    TransactionRepository.TransactionsData(Ltransaction);
                    return Ltransaction;
                }
            }
            else
            {
                if (depositAndWithdraw.SavingsBalance!=0)
                {
                    Ltransaction.DateRange = DateTime.Now;
                    Ltransaction.Particulars = (depositAndWithdraw.AccountId).ToString() + "Deposit";
                    Ltransaction.Wihtdraw = null;
                 //   var x = (from b in result1 select b.SavingsBalance);
                   // double r = Convert.ToDouble(x);
                    Ltransaction.Deposit = depositAndWithdraw.Amount;
                    Ltransaction.Balance = 0.0;
                    Ltransaction.SavingsBalance = depositAndWithdraw.SavingsBalance + depositAndWithdraw.Amount;
                    Ltransaction.CurrentBalance = 0.0;
                    Ltransaction.CustomerId = 1;
                    TransactionRepository.TransactionsData(Ltransaction);
                    return Ltransaction;
                }
                else
                {
                    Ltransaction.DateRange = DateTime.Now;
                    Ltransaction.Particulars = (depositAndWithdraw.AccountId).ToString() + "Deposit";
                    Ltransaction.Wihtdraw = null;
                    Ltransaction.Deposit = depositAndWithdraw.Amount;
                    Ltransaction.Balance = 0.0;
                    Ltransaction.SavingsBalance = 0.0;
                    Ltransaction.CurrentBalance = depositAndWithdraw.CurrentBalance + depositAndWithdraw.Amount;
                    Ltransaction.CustomerId = 1;
                    TransactionRepository.TransactionsData(Ltransaction);
                    return Ltransaction;
                    
                }
            }
            return null;
            //TransactionRepository.TransactionsData(Ltransaction);
            //return Ltransaction;
        }
    }
}