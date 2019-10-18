using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerData.Api.Models
{
    public class TransactionModel
    {
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public CustomerModel Customer { get; set; }
    }
}