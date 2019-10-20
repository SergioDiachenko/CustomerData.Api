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
        Task<Customer> GetCustomerByIdAsync(int customerId);
        Task<Customer> GetCustomerByEmailAsync(string email);
        Task<Customer[]> GetAllCustomersAsync();
        Task<bool> SaveChangesAsync();
    }
}