using CustomerData.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerData.Api.Models
{
    public class CustomerModel
    {
        public string Name { get; set; }
        public string ContactEmail { get; set; }
        public string MobileNumber { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}