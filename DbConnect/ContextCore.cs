using Microsoft.EntityFrameworkCore;
using System;
namespace BTG_CRM.DbConnect
{
    public class ContextCore : DbContext
    {
        public ContextCore(DbContextOptions<ContextCore> options) : base(options)
        {

        }
    }
}
