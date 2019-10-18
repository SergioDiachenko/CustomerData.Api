using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerData.Api.Data.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactEmail { get; set; }
        public string MobileNumber { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}