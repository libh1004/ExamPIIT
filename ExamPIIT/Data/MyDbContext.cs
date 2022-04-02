using ExamPIIT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamPIIT.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=ConnectionString")
        {

        }
        public DbSet<Coin> Coins { get; set; }
        public DbSet<Market> Markets { get; set; }
    }
}