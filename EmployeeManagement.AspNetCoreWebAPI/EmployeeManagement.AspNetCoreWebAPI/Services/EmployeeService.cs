using EmployeeManagement.AspNetCoreWebAPI.Models;
using EmployeeManagement.AspNetCoreWebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.AspNetCoreWebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmpContext _empContext;

        public EmployeeService(EmpContext empContext)
        {
            _empContext = empContext;

        }
        public Employees SearchEmployee(int empid)
        {
            Employees emp;

            try
            {
                emp = _empContext.Find<Employees>(empid);

            }
            catch (Exception ex)
            {
                throw ex;
            }

                
            return emp;
        }

        public IList<Employees> GetEmployeesList()
        {

            IList<Employees> lstEmployees;

            try
            {

                lstEmployees = _empContext.Set<Employees>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstEmployees;
        }

        public ResponseModel SaveEmployee(Employees employee)
        {

            ResponseModel model = new ResponseModel();

            try
            {
                _empContext.Add<Employees>(employee);

                _empContext.SaveChanges();
                model.IsSuccess = true;

                model.Message = " Employee records saved succesfully";
            }

            catch (Exception ex)
            {
                model.IsSuccess = false;

                model.Message = " Error:"+ex.Message;
                
            }


            return model;
        }
    }
}
