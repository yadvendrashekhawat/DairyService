using Dairy.Customer.Model.Request;
using Dairy.Customer.Model.Response;
using Dairy.Customer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dairy.Customer.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        public IEnumerable<CustomerResponse> GetCustomer()
        {
            List<CustomerResponse> customerList = new List<CustomerResponse>() {
                        new CustomerResponse(){ CustomerId = "CUST001", CustomerFirstName = "Yadvendra", CustomerMiddleName = "Singh", CustomerLastName = "Shekhawat", CustomerHouseFlatNo = "B-36", CustomerAddress1 = "Triveni Nagar",
                CustomerAddress2 = "Gopal Pura By Pass", CustomerCity = "Jaipur", CustomerCountry = "India", CustomerState = "Rajasthan", CustomerIsActive = true, CustomerIsDeleted = false, CustomerPincode = "302018" },
                        new CustomerResponse(){ CustomerId = "CUST002", CustomerFirstName = "Shrawan", CustomerMiddleName = "Singh", CustomerLastName = "Shekhawat", CustomerHouseFlatNo = "B-36", CustomerAddress1 = "Triveni Nagar",
                CustomerAddress2 = "Gopal Pura By Pass", CustomerCity = "Jaipur", CustomerCountry = "India", CustomerState = "Rajasthan", CustomerIsActive = true, CustomerIsDeleted = false, CustomerPincode = "302018" },
                        new CustomerResponse(){ CustomerId = "CUST003", CustomerFirstName = "Yogita", CustomerMiddleName = "Singh", CustomerLastName = "Shekhawat", CustomerHouseFlatNo = "B-36", CustomerAddress1 = "Triveni Nagar",
                CustomerAddress2 = "Gopal Pura By Pass", CustomerCity = "Jaipur", CustomerCountry = "India", CustomerState = "Rajasthan", CustomerIsActive = true, CustomerIsDeleted = false, CustomerPincode = "302018" }
            };
            return customerList.AsEnumerable();
        }

        public bool InsertCustomer(CustomerRequest request)
        {
            return true;
        }

        public bool UpdateCustomer(CustomerRequest request)
        {
            return true;
        }

        public bool DeleteCustomer(int customerId)
        {
            return true;
        }

        public IEnumerable<CustomerResponse> GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
