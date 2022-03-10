using EmployeeManagement.AspNetCoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.AspNetCoreWebAPI.ViewModels;

namespace EmployeeManagement.AspNetCoreWebAPI.Services
{
 public   interface IEmployeeService
    {
       /// <summary>
       /// get all the employees list
       /// </summary>
       /// <returns></returns>
      IList<Employees>  GetEmployeesList();

        /// <summary>
        /// Get employee detail based on emp id
        /// </summary>
        /// <param name="empid"></param>
        Employees SearchEmployee(int empid);

        /// <summary>
        /// Save one employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        ResponseModel SaveEmployee(Employees employee);


    }
}
