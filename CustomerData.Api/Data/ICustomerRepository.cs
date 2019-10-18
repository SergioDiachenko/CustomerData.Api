using CustomerData.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CustomerData.Api.Data
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void AddTransaction(Transaction transaction);
        Task<Customer> GetCustomerAsync(int id);
        Task<Customer[]> GetAllCustomersAsync();
        Task<bool> SaveChangesAsync();
    }
}