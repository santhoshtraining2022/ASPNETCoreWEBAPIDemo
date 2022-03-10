using EmployeeManagement.AspNetCoreWebAPI.Models;
using EmployeeManagement.AspNetCoreWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.AspNetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {       

         private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }

        [HttpGet]

        [Route("[action]")]
        public IActionResult GetAllEmployees()
        {

            try
            {

                var employees = _employeeService.GetEmployeesList();

                if (employees == null) return NotFound();

                return Ok(employees);

            }

            catch( Exception ex )
            {

                return BadRequest();
            }
           
        }
        [HttpGet]

        [Route("[action]/empid")]
        public IActionResult SearchEmployeeByEmpID(int empid)
        {

            try
            {

                var employee = _employeeService.SearchEmployee(empid);

                if (employee == null) return NotFound();

                return Ok(employee);

            }

            catch (Exception ex)
            {

                return BadRequest();
            }

        }

        [HttpPost]

        [Route("[action]")]
        public IActionResult SaveEmployeeByEmpID(Employees employeeData)
        {

            try
            {

                var responseModel = _employeeService.SaveEmployee(employeeData);

                if (responseModel == null) return NotFound();

                return Ok(responseModel);

            }

            catch (Exception ex)
            {

                return BadRequest();
            }

        }
    }
}
