using CustomerData.Api.Data.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerData.Api.Models
{
    public class CustomerModel
    {
        [JsonProperty(PropertyName = "customerID")]
        [Range(1, 9, ErrorMessage = "Invalid Id")]
        public int? Id { get; set; }
        public string Name { get; set; }
        [JsonProperty(PropertyName = "email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid Email")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Invalid Email")]
        public string ContactEmail { get; set; }
        public string MobileNumber { get; set; }
        public ICollection<TransactionModel> Transactions { get; set; }
    }
}