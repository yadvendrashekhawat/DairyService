using System;
using System.Collections.Generic;
using System.Text;

namespace Dairy.Customer.Model.Models
{
    public class ResponseViewModel<T>
    {

        public string NotificationType { get; set; }
        public bool isSuccess { get; set; }
        public string Message { get; set; }
        public string Id { get; set; }
        public int Count { get; set; }
        public IEnumerable<T> Data { get; set; }        
    }
}
