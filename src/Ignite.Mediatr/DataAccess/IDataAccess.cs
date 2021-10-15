using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ignite.Mediatr.Models;

namespace Ignite.Mediatr.DataAccess
{
    public interface IDataAccess
    {
        Task<List<Employee>> GetEmployees();

        Employee AddEmployee(string firstName, string lastName);
    }

    public class EmployeeDataAccess : IDataAccess
    {
        private List<Employee> _employees = new List<Employee>();
        public EmployeeDataAccess()
        {
            _employees.Add(new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith"
            });

            _employees.Add(new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe"
            });
        }

        public Employee AddEmployee(string firstName, string lastName)
        {
            return new Employee {
                FirstName = firstName, 
                LastName = lastName,
                Id = _employees.Max(x => x.Id) + 1
            };
        }

        public Task<List<Employee>> GetEmployees()
        {
            return Task.FromResult(_employees);
        }
    }
}
