using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dairy.Customer.Model.Models;
using Dairy.Customer.Model.Request;
using Dairy.Customer.Model.Response;
using Dairy.Customer.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DairyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("GetCustomer")]
        public ActionResult<ResponseViewModel<CustomerResponse>> GetCustomer()
        {
            ResponseViewModel<CustomerResponse> respnose = new ResponseViewModel<CustomerResponse>();
            try
            {
                var customerList = _customerService.GetCustomer();
                if (customerList != null && customerList.Count() > 0)
                {
                    respnose.isSuccess = true;
                    respnose.Data = customerList;
                    respnose.NotificationType = ResponseStatusEnum.SUCCESS.ToString();
                    respnose.Count = customerList.Count();
                    respnose.Id = null;
                    respnose.Message = respnose.Count + "  Records found.";
                }
                else
                {
                    respnose.isSuccess = false;
                    respnose.Data = customerList;
                    respnose.NotificationType = ResponseStatusEnum.RECORDNOTFOUND.ToString();
                    respnose.Message = "Records Not Found";
                }
            }
            catch (Exception ex)
            {
                respnose.isSuccess = false;
                respnose.Data = null;
                respnose.NotificationType = ResponseStatusEnum.ERROR.ToString();
                respnose.Message = ex.InnerException.ToString(); ;
            }
            return respnose;           
        }

        [HttpDelete("DeleteCustomer/id/{id}")]
        public ActionResult<ResponseViewModel<CustomerResponse>> DeleteCustomer(int customerId)
        {
            ResponseViewModel<CustomerResponse> respnose = new ResponseViewModel<CustomerResponse>();
            try
            {  
                if (_customerService.DeleteCustomer(customerId))
                {
                    respnose.isSuccess = true;
                    respnose.Data = null;
                    respnose.NotificationType = ResponseStatusEnum.SUCCESS.ToString();
                    respnose.Message = "";
                }
                else
                {
                    respnose.isSuccess = false;
                    respnose.Data = null;
                    respnose.NotificationType = ResponseStatusEnum.RECORDNOTFOUND.ToString();
                    respnose.Message = "Records Not Found";
                }
            }
            catch (Exception ex)
            {
                respnose.isSuccess = false;
                respnose.Data = null;
                respnose.NotificationType = ResponseStatusEnum.ERROR.ToString();
                respnose.Message = ex.InnerException.ToString(); ;
            }
            return respnose;
        }

        [HttpPut("UpdateCustomer")]
        public ActionResult<ResponseViewModel<CustomerResponse>> UpdateCustomer(CustomerRequest request)
        {
            ResponseViewModel<CustomerResponse> respnose = new ResponseViewModel<CustomerResponse>();
            try
            {
                if (_customerService.UpdateCustomer(request))
                {
                    respnose.isSuccess = true;
                    respnose.Data = null;
                    respnose.NotificationType = ResponseStatusEnum.SUCCESS.ToString();
                    respnose.Message = "Record Update Successfully";
                }
                else
                {
                    respnose.isSuccess = false;
                    respnose.Data = null;
                    respnose.NotificationType = ResponseStatusEnum.RECORDNOTFOUND.ToString();
                    respnose.Message = "Records Not Found";
                }
            }
            catch (Exception ex)
            {
                respnose.isSuccess = false;
                respnose.Data = null;
                respnose.NotificationType = ResponseStatusEnum.ERROR.ToString();
                respnose.Message = ex.InnerException.ToString(); ;
            }
            return respnose;
        }

        [HttpPost("InsertCustomer")]
        public ActionResult<ResponseViewModel<CustomerResponse>> InsertCustomer(CustomerRequest request)
        {
            ResponseViewModel<CustomerResponse> respnose = new ResponseViewModel<CustomerResponse>();
            try
            {
                if (_customerService.InsertCustomer(request))
                {
                    respnose.isSuccess = true;
                    respnose.Data = null;
                    respnose.NotificationType = ResponseStatusEnum.SUCCESS.ToString();
                    respnose.Message = "Record Inserted Successfully";
                }
                else
                {
                    respnose.isSuccess = false;
                    respnose.Data = null;
                    respnose.NotificationType = ResponseStatusEnum.ERROR.ToString();
                    respnose.Message = "Records Not Inserted";
                }
            }
            catch (Exception ex)
            {
                respnose.isSuccess = false;
                respnose.Data = null;
                respnose.NotificationType = ResponseStatusEnum.ERROR.ToString();
                respnose.Message = "Records Not Inserted";
            }
            return respnose;
        }

        [HttpGet("GetCustomerById/id/{id}")]
        public ActionResult<ResponseViewModel<CustomerResponse>> GetCustomerById(int customerId)
        {
            ResponseViewModel<CustomerResponse> respnose = new ResponseViewModel<CustomerResponse>();
            try
            {
                var customerList = _customerService.GetCustomerById(customerId);
                if (customerList != null && customerList.Count() > 0)
                {
                    respnose.isSuccess = true;
                    respnose.Data = customerList;
                    respnose.NotificationType = ResponseStatusEnum.SUCCESS.ToString();
                    respnose.Message = "";
                }
                else
                {
                    respnose.isSuccess = false;
                    respnose.Data = null;
                    respnose.NotificationType = ResponseStatusEnum.RECORDNOTFOUND.ToString();
                    respnose.Message = "Records Not Found";
                }
            }
            catch (Exception ex)
            {
                respnose.isSuccess = false;
                respnose.Data = null;
                respnose.NotificationType = ResponseStatusEnum.ERROR.ToString();
                respnose.Message = ex.InnerException.ToString(); ;
            }
            return respnose;
        }
    }
}
