using Microsoft.AspNetCore.Mvc;
using ASP.NetcoreAPIProject.Services.Interface;
using ASP.NetcoreAPIProject.Models;
namespace ASP.NetcoreAPIProject.Controllers
{
    [Route("EmployeeModel")]
    public class EmployeeController: ControllerBase
    {
        private readonly IEmployeeService _employeeService;


        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // CREATE
        [HttpPost("Create")]
        public IActionResult CreateEmployee([FromBody] EmployeeModel employee)
        {
            _employeeService.CreateEmployee(employee);
            return new JsonResult("Employee Created Succesfully.");

        }


        // READ WRT Id
        [HttpGet("GetEmployee/{id}")]
        public IActionResult GetEmployees([FromRoute] int id)
        {
            return new JsonResult(_employeeService.GetEmployee(id));
        }

        // READ
        [HttpGet("GetEmployees")]
        public IActionResult GetEmployees()
        {
            return new JsonResult(_employeeService.GetEmployees());
        }

        // UPDATE
        [HttpPut("Update")]
        public IActionResult UpdateEmployee([FromBody] EmployeeModel employee)
        {
            _employeeService.UpdateEmployee(employee);
            return new JsonResult("Employee Updated Succesfully.");

        }


        // DELETE
        [HttpDelete("Delete")]
        public IActionResult DeleteEmployee([FromQuery] int id)
        {

            return new JsonResult(_employeeService.DeleteEmployee(id));

        }
    }
}
