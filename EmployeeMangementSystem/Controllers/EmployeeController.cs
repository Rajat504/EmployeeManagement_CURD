// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Rajat Ravindar"/>
// --------------------------------------------------------------------------------------------------------------------

namespace EmployeeMangementCurd_Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Manager.ManagerInterface;
    using Microsoft.AspNetCore.Mvc;
    using Model;

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeManager manager;
        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;
        }
        
        [Route("AddEmployee")]
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

        [Route("GetAllEmployee")]
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(await manager.GetAllEmployees());
        }

        [Route("UpdateEmployee")]
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

        [HttpDelete]
        [Route("DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
        }

        //[Route("GetEmployee")]
        [HttpGet("GetEmployee/{id}")]
        public Employee GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
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
    }
}