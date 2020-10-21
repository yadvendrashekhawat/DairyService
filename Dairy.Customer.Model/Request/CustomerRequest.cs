using System;
using System.Collections.Generic;
using System.Text;

namespace Dairy.Customer.Model.Request
{
    public class CustomerRequest
    {
        public string customerId { get; set; }
        public string customerFirstName { get; set; }
        public string customerMiddleName { get; set; }
        public string customerLastName { get; set; }
        public string customerHouseFlatNo{ get; set; }
        public string customerAddress1 { get; set; }
        public string customerAddress2 { get; set; }
        public string customerStreet { get; set; }
        public string customerCity { get; set; }
        public string customerState { get; set; }
        public string customerPincode { get; set; }
        public string customerCountry { get; set; }
        public string customerIsActive { get; set; }
        public string customerIsDeleted { get; set; }
    }
}
