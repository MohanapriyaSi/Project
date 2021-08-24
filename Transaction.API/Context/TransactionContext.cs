using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transaction.API.Models;


namespace Transaction.API.Context
{
    public class TransactionContext : DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> context) : base(context)
        {

        }
        public virtual DbSet<TransactionDetails> TransactionsLog { get; set; }
        public virtual DbSet<UserTransaction> userTransaction { get; set; }
    }
}
