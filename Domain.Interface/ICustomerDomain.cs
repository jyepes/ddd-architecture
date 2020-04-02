using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ICustomerDomain
    {
        #region Métodos síncronos

        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(string customerID);
        Customer GetCustomerById(string customerId);
        IEnumerable<Customer> GetAll();

        #endregion

        #region Métodos asíncronos

        Task<bool> InsertAsync(Customer customer);
        Task<bool> UpdateAsync(Customer customer);
        Task<bool> DeleteAsync(string customerID);
        Task<Customer> GetCustomerByIdAsync(string customerId);
        Task<IEnumerable<Customer>> GetAllAsync();

        #endregion
    }
}
