using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dairy.Customer.Model.Response
{
    public class CustomerResponse
    {
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("customerFirstName")]
        public string CustomerFirstName { get; set; }
        
        [JsonProperty("customerMiddleName")]
        public string CustomerMiddleName { get; set; }
        
        [JsonProperty("customerLastName")]
        public string CustomerLastName { get; set; }
        
        [JsonProperty("customerHouseFlatNo")]
        public string CustomerHouseFlatNo { get; set; }
        
        [JsonProperty("customerAddress1")]
        public string CustomerAddress1 { get; set; }
        
        [JsonProperty("customerAddress2")]
        public string CustomerAddress2 { get; set; }
        
        [JsonProperty("customerCity")]
        public string CustomerCity { get; set; }
        
        [JsonProperty("customerState")]
        public string CustomerState { get; set; }
        
        [JsonProperty("customerPincode")]
        public string CustomerPincode { get; set; }
        
        [JsonProperty("customerCountry")]
        public string CustomerCountry { get; set; }
        
        [JsonProperty("customerIsActive")]
        public bool CustomerIsActive { get; set; }
        
        [JsonProperty("customerIsDeleted")]
        public bool CustomerIsDeleted { get; set; }
    }
}
