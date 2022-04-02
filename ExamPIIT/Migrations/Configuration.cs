namespace ExamPIIT.Migrations
{
    using ExamPIIT.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExamPIIT.Data.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExamPIIT.Data.MyDbContext context)
        {
            var markets = new List<Market>
            {
                new Market{Name = "Binance", Description = "", Status = StatusValue.Active},
                new Market{Name = "Coinbase Exchange", Description = "", Status = StatusValue.Deactive},
                new Market{Name = "FTX", Description = "", Status = StatusValue.Active},
                new Market{Name = "OKX", Description = "", Status = StatusValue.Deactive},
                new Market{Name = "Upbit", Description = "", Status = StatusValue.Deactive},
                new Market{Name = "WhiteBIT", Description = "", Status = StatusValue.Active},
                new Market{Name = "Korbit", Description = "", Status = StatusValue.Active},
                new Market{Name = "BitMart", Description = "", Status = StatusValue.Active},
                new Market{Name = "Deepcoin", Description = "", Status = StatusValue.Deactive},
                new Market{Name = "Bitbank", Description = "", Status = StatusValue.Deactive},
            };
            markets.ForEach(m => context.Markets.Add(m));
            context.SaveChanges();
        }
    }
}
