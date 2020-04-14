using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.ManagerInterface;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace EmployeeManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly IEmployeeManager manager;

        public ValuesController(IEmployeeManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// method to add employee data.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>  Updated Employee Data </returns>
        [Route("Addemployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
               
                return this.BadRequest();
            }
        }

        /// <summary>
        /// method to get all employees data.
        /// </summary>
        /// <returns> Updated Employee Data </returns>
        [Route("GetAllEmployees")]
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {

            return Ok(await manager.GetAllEmployees());
        }

        /// <summary>
        /// method to update employee data.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns> Updated Employee Data </returns>
        [Route("UpdateEmployeeInDB")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }


        [Route("LoginEmployee")]
        [HttpPost]
        public IActionResult LoginEmployee(string email, string password)
        {
            var result = this.manager.LoginEmployee(email, password);
            if (result == true)
            {
                return this.Ok(email);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// method to delete from employee data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
        [HttpDelete]
        [Route("DeleteEmployeeFromDB")]
        public Employee DeleteEmployee(int id)
        {
           // Log.Information("Employee Deleted");
            return this.manager.DeleteEmployee(id);
        }

        /// <summary>
        /// method to get employee data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
        [Route("GetEmployeeFromDB")]
        [HttpGet]
        public Employee GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }
    }
}
