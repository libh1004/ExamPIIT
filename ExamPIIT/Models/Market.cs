using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamPIIT.Models
{
    public enum StatusValue
    {
        Active,
        Deactive
    }
    public class Market
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public StatusValue Status { get; set; }
    }
}