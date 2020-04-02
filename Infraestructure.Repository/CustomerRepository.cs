using System;
using Transversal.Common;
using Infraestructure.Interface;
using Domain.Entity;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Infraestructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IConnectionFactory connectionFactory;

        public CustomerRepository(IConnectionFactory _connectionFactory)
        {
            connectionFactory = _connectionFactory;
        }

        #region Métodos síncronos
        public bool Insert(Customer customer)
        {

            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerID);
                parameters.Add("CompanyName", customer.CustomerID);
                parameters.Add("ContactName", customer.CustomerID);
                parameters.Add("ContactTitle", customer.CustomerID);
                parameters.Add("Address", customer.CustomerID);
                parameters.Add("City", customer.CustomerID);
                parameters.Add("Region", customer.CustomerID);
                parameters.Add("PostalCode", customer.CustomerID);
                parameters.Add("Country", customer.CustomerID);
                parameters.Add("Phone", customer.CustomerID);
                parameters.Add("Fax", customer.CustomerID);

                var result = connection.Execute(sp, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool Update(Customer customer)
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerID);
                parameters.Add("CompanyName", customer.CustomerID);
                parameters.Add("ContactName", customer.CustomerID);
                parameters.Add("ContactTitle", customer.CustomerID);
                parameters.Add("Address", customer.CustomerID);
                parameters.Add("City", customer.CustomerID);
                parameters.Add("Region", customer.CustomerID);
                parameters.Add("PostalCode", customer.CustomerID);
                parameters.Add("Country", customer.CustomerID);
                parameters.Add("Phone", customer.CustomerID);
                parameters.Add("Fax", customer.CustomerID);

                var result = connection.Execute(sp, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool Delete(string customerId)
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customerId);
                var result = connection.Execute(sp, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Customer GetCustomerById(string customerId)
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersGetByID";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customerId);
                var customer = connection.QuerySingle<Customer>(sp, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersList";
                var customers = connection.Query<Customer>(sp, commandType: CommandType.StoredProcedure);
                return customers;
            }
        }

        #endregion

        #region Métodos asíncronos
        public async Task<bool> InsertAsync(Customer customer)
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerID);
                parameters.Add("CompanyName", customer.CustomerID);
                parameters.Add("ContactName", customer.CustomerID);
                parameters.Add("ContactTitle", customer.CustomerID);
                parameters.Add("Address", customer.CustomerID);
                parameters.Add("City", customer.CustomerID);
                parameters.Add("Region", customer.CustomerID);
                parameters.Add("PostalCode", customer.CustomerID);
                parameters.Add("Country", customer.CustomerID);
                parameters.Add("Phone", customer.CustomerID);
                parameters.Add("Fax", customer.CustomerID);

                var result = await connection.ExecuteAsync(sp, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerID);
                parameters.Add("CompanyName", customer.CustomerID);
                parameters.Add("ContactName", customer.CustomerID);
                parameters.Add("ContactTitle", customer.CustomerID);
                parameters.Add("Address", customer.CustomerID);
                parameters.Add("City", customer.CustomerID);
                parameters.Add("Region", customer.CustomerID);
                parameters.Add("PostalCode", customer.CustomerID);
                parameters.Add("Country", customer.CustomerID);
                parameters.Add("Phone", customer.CustomerID);
                parameters.Add("Fax", customer.CustomerID);

                var result = await connection.ExecuteAsync(sp, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<bool> DeleteAsync(string customerId)
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customerId);
                var result = await connection.ExecuteAsync(sp, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public async Task<Customer> GetCustomerByIdAsync(string customerId)
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersGetByID";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customerId);
                var customer = await connection.QuerySingleAsync<Customer>(sp, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;
            }
        }  
        
        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var sp = "CustomersList";
                var customers = await connection.QueryAsync<Customer>(sp, commandType: CommandType.StoredProcedure);
                return customers;
            }
        }

        #endregion

    }
}
