using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;

namespace Infraestructure.Interface
{
    public interface ICustomerRepository
    {
        bool Insert(Customer cusotmer);
        bool Update(Customer customer);
        bool Delete(string customerID);
        Customer GetCustomerById(string customerId);
        IEnumerable<Customer> GetAll();
    }
}
