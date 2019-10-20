using CustomerData.Api.Data.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerData.Api.Models
{
    public class CustomerModel
    {
        [JsonProperty(PropertyName = "customerID")]
        [Range(1, 999999999)]
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty(PropertyName = "email")]
        [StringLength(25, MinimumLength = 5)]
        public string ContactEmail { get; set; }
        public string MobileNumber { get; set; }
        public ICollection<TransactionModel> Transactions { get; set; }
        public bool IsValidEmail()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(ContactEmail);
                return addr.Address == ContactEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}