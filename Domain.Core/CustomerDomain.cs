using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using Domain.Interface;
using Infraestructure.Interface;
using System.Threading.Tasks;

namespace Domain.Core
{
    public class CustomerDomain: ICustomerDomain
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerDomain(ICustomerRepository _customerRepository)
        {
            customerRepository = _customerRepository;
        }

        #region Métodos síncronos
        public bool Insert(Customer customer)
        {
            //reglas de negocio
            //...
            //...
            return customerRepository.Insert(customer);
        }

        public bool Update(Customer customer)
        {
            //reglas de negocio
            //...
            //...
            return customerRepository.Update(customer);
        }

        public bool Delete(string customerID)
        {
            //reglas de negocio
            //...
            //...
            return customerRepository.Delete(customerID);
        }

        public Customer GetCustomerById(string customerId)
        {
            //reglas de negocio
            //...
            //...
            return customerRepository.GetCustomerById(customerId);
        }
        public IEnumerable<Customer> GetAll()
        {
            //reglas de negocio
            //...
            //...
            return customerRepository.GetAll();
        }
        #endregion

        #region Métodos asíncronos

        public async Task<bool> InsertAsync(Customer customer)
        {
            //reglas de negocio
            //...
            //...
            return await customerRepository.InsertAsync(customer);
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            //reglas de negocio
            //...
            //...
            return await customerRepository.UpdateAsync(customer);
        }
        public async Task<bool> DeleteAsync(string customerID)
        {
            //reglas de negocio
            //...
            //...
            return await customerRepository.DeleteAsync(customerID);
        }


        public async Task<Customer> GetCustomerByIdAsync(string customerId)
        {
            //reglas de negocio
            //...
            //...
            return await customerRepository.GetCustomerByIdAsync(customerId);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            //reglas de negocio
            //...
            //...
            return await customerRepository.GetAllAsync();
        }
        #endregion

    }
}
