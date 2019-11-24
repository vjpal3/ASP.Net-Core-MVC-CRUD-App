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

        public Employee Add(Employee employee)
        {
            employee.Id = employeeList.Max(e => e.Id) + 1;
            employeeList.Add(employee);
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);

            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = employeeList.FirstOrDefault(e => e.Id == id);

            if(employee != null)
            {
                employeeList.Remove(employee);
            }
            return employee;
        }
    }
}
