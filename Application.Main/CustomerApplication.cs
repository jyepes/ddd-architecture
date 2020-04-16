using System;
using AutoMapper;
using Application.DTO;
using Application.Interface;
using Domain.Interface;
using Domain.Entity;
using Transversal.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Application.Main
{
    public class CustomerApplication: ICustomerApplication
    {
        private readonly ICustomerDomain customerDomain;
        private readonly IMapper mapper;
        private readonly IAppLogger<CustomerApplication> logger;
        public CustomerApplication(ICustomerDomain _customerDomain, IMapper _mapper, IAppLogger<CustomerApplication> _logger)
        {
            customerDomain = _customerDomain;
            mapper = _mapper;
            logger = _logger;
        }

        #region Métodos síncronos
        public Response<bool> Insert(CustomerDto customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = mapper.Map<Customer>(customerDto);
                response.Data = customerDomain.Insert(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Ok";
                    logger.LogInformation("Se se ha creado el cliente de forma exitosa");
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                logger.LogError(ex.Message);
            }

            return response;
        }

        public Response<bool> Update(CustomerDto customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = mapper.Map<Customer>(customerDto);
                response.Data = customerDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Ok";
                    logger.LogInformation("Se actualizó el cliente de forma exitosa");
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                logger.LogError(ex.Message);
            }

            return response;
        }

        public Response<bool> Delete(string customerID)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = customerDomain.Delete(customerID);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Ok";
                    logger.LogInformation("Se eliminó el cliente de forma exitosa");
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                logger.LogError(ex.Message);
            }

            return response;
        }

        public Response<IEnumerable<CustomerDto>> GetAll()
        {
            var response = new Response<IEnumerable<CustomerDto>>();
            try
            {
                var customers = customerDomain.GetAll();
                response.Data = mapper.Map<IEnumerable<CustomerDto>>(customers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Ok";                
                    logger.LogInformation("Se ejecutó la consulta de forma exitosa");
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                logger.LogError(ex.Message);
            }

            return response;
        }

        public Response<CustomerDto> GetCustomerById(string customerId)
        {
            var response = new Response<CustomerDto>();
            try
            {
                var customer = customerDomain.GetCustomerById(customerId);
                response.Data = mapper.Map<CustomerDto>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Ok";
                    logger.LogInformation("Se ejecutó la consulta de forma exitosa");
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                logger.LogError(ex.Message);
            }

            return response;
        }
        #endregion

        #region Métodos asíncronos

        public async Task<Response<bool>> InsertAsync(CustomerDto customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = mapper.Map<Customer>(customerDto);
                response.Data = await customerDomain.InsertAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Ok";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async  Task<Response<bool>> UpdateAsync(CustomerDto customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = mapper.Map<Customer>(customerDto);
                response.Data = await customerDomain.UpdateAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Ok";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<bool>> DeleteAsync(string customerID)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await customerDomain.DeleteAsync(customerID);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Ok";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }


        public async Task<Response<IEnumerable<CustomerDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomerDto>>();
            try
            {
                var customers = await customerDomain.GetAllAsync();
                response.Data = mapper.Map<IEnumerable<CustomerDto>>(customers);
                if (response.Data != null)
                {

                }
                response.IsSuccess = true;
                response.Message = "Ok";

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }



        public async Task<Response<CustomerDto>> GetCustomerByIdAsync(string customerId)
        {
            var response = new Response<CustomerDto>();
            try
            {
                var customer = await customerDomain.GetCustomerByIdAsync(customerId);
                response.Data = mapper.Map<CustomerDto>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Ok";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        #endregion

    }
}
