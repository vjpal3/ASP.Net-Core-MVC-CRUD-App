using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_Core_MVC_CRUD_App.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;

        public MockEmployeeRepository()
        {
            employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@softec.com" },
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@softec.com" },
                new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@softec.com" }
            };

        }
        public Employee GetEmployee(int Id)
        {
            return employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeList;
        }
    }
}
