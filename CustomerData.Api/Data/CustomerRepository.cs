using CustomerData.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace CustomerData.Api.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDataContext _context;

        public CustomerRepository(CustomerDataContext context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
        }

        public async Task<Customer> GetCustomerAsync(int customerId)
        {
             return await _context.Customers.Include(c => c.Transactions).FirstOrDefaultAsync(c => c.Id == customerId);
        }

        public async Task<Customer[]> GetAllCustomersAsync()
        {
            return await _context.Customers.Include("Transactions").ToArrayAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}