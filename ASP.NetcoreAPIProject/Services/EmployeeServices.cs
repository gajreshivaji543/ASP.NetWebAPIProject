using ASP.NetcoreAPIProject.Models;
using ASP.NetcoreAPIProject.Services.Interface;
using System.Collections.Generic;
using System.Linq;
namespace ASP.NetcoreAPIProject.Services
{
    public class EmployeeServices
    {
        public class EmployeeService : IEmployeeService
        {
            private List<EmployeeModel> _employees;



            public EmployeeService()
            {
                _employees = new List<EmployeeModel>()
            {
                new EmployeeModel() { Id = 1, Name = "Goutham"},
                new EmployeeModel() { Id = 2 ,Name = "Arshdeep"}
            };
            }

            // CREATE
            public void CreateEmployee(EmployeeModel employee)
            {
                _employees.Add(employee);

            }

            // READ
            public EmployeeModel GetEmployee(int id)
            {
                return _employees.Where(x => x.Id == id).FirstOrDefault();
            }


            public IEnumerable<EmployeeModel> GetEmployees()
            {
                return _employees;
            }

            //UPDATE
            public void UpdateEmployee(EmployeeModel employee)
            {

                var originalEmployee = GetEmployee(employee.Id);
                if (originalEmployee != null)
                {

                    _employees.ForEach(item =>
                    {
                        if (item.Id == employee.Id)
                        {
                            item.Name = employee.Name;
                        }
                    }
                    );
                }
                else
                {
                    _employees.Add(employee);
                }
            }

            //DELETE
            public bool DeleteEmployee(int id)
            {
                _employees = _employees.Where(x => x.Id != id).ToList();
                return true;
            }
        }
    }
}
