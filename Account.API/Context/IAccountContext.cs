using Account.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.API.Context
{
    public interface IAccountContext
    {
       
        public DbSet<AccountDetails> Account { get; set; }

    }
}
