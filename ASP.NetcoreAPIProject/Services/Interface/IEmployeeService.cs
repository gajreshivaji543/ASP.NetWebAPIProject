using System.Collections.Generic;
using ASP.NetcoreAPIProject.Models;
namespace ASP.NetcoreAPIProject.Services.Interface
{
    public interface IEmployeeService
    {
        void CreateEmployee(EmployeeModel employee);

        // READ
        IEnumerable<EmployeeModel> GetEmployees();

        // READ WRT ID
        EmployeeModel GetEmployee(int id);

        //UPDATE
       void UpdateEmployee(EmployeeModel employee);

        //DELETE
        bool DeleteEmployee(int id);
    }
}
