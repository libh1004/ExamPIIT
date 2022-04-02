using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamPIIT.Models
{
    public enum Status
    {
        Active,
        Deactive
    }
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BaseAsset { get; set; }
        public string QuoteAsset { get; set; }
        public string LastPrice { get; set; }
        public int Volumn24h { get; set; }
        public Market MarketId { get; set; }
        public Status Status { get; set; }
    }
}