using System;
using System.Collections.Generic;
using System.Text;
using Application.DTO;
using Transversal.Common;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICustomerApplication
    {
        #region Métodos síncronos

        Response<bool> Insert(CustomerDto customerDto);
        Response<bool> Update(CustomerDto customerDto);
        Response<bool> Delete(string customerID);
        Response<CustomerDto> GetCustomerById(string customerId);
        Response<IEnumerable<CustomerDto>> GetAll();

        #endregion

        #region Métodos asíncronos

        Task<Response<bool>> InsertAsync(CustomerDto customerDto);
        Task<Response<bool>> UpdateAsync(CustomerDto customerDto);
        Task<Response<bool>> DeleteAsync(string customerID);
        Task<Response<CustomerDto>> GetCustomerByIdAsync(string customerId);
        Task<Response<IEnumerable<CustomerDto>>> GetAllAsync();

        #endregion
    }
}
