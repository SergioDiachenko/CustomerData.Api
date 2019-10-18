using CustomerData.Api.Data.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerData.Api.Models
{
    public class CustomerModel
    {
        [JsonProperty(PropertyName = "customerID")]
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string ContactEmail { get; set; }
        public string MobileNumber { get; set; }
        public ICollection<TransactionModel> Transactions { get; set; }
    }
}