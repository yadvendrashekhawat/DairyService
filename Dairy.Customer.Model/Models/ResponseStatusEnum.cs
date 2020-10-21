using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dairy.Customer.Model.Models
{   
    public enum ResponseStatusEnum
    {
        [Display(Name = "Sucess")]
        SUCCESS = 1,

        [Display(Name = "Error")]
        ERROR = 2,

        [Display(Name = "Warning")]
        WARNING = 3,

        [Display(Name = "Info")]
        INFO = 4,

        [Display(Name = "RecordNotFound")]
        RECORDNOTFOUND = 5
    }
}
