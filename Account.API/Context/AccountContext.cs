using Account.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.API.Context
{
    public class AccountContext:DbContext,IAccountContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {

        }
        public virtual DbSet<AccountDetails> Account { get; set; }
        
    }
}
