using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.AspNetCoreWebAPI.ViewModels
{
    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
