using Dairy.Customer.Model.Request;
using Dairy.Customer.Model.Response;
using System.Collections.Generic;

namespace Dairy.Customer.Services.Interface
{
    public interface ICustomerService
    {
        IEnumerable<CustomerResponse> GetCustomer();
        bool InsertCustomer(CustomerRequest request);
        bool UpdateCustomer(CustomerRequest request);
        bool DeleteCustomer(int customerId);
        IEnumerable<CustomerResponse> GetCustomerById(int customerId);
    }
}
