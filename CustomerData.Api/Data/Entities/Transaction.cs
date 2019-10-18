using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerData.Api.Data.Entities
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}