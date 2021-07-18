using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Data
{
    public class DataAccess : IDataAccess
    {
        private List<EmployeeModel> _employees = new();
        public DataAccess()
        {
            _employees.Add(new EmployeeModel { Id = 1, FirstName = "Pritom", LastName = "Paul" });
            _employees.Add(new EmployeeModel { Id = 2, FirstName = "Jugal", LastName = "Paul" });
            _employees.Add(new EmployeeModel { Id = 3, FirstName = "Pinky", LastName = "Paul" });
        }

        public EmployeeModel AddEmployee(string firstName, string lastName)
        {
            EmployeeModel newEmployee = new() { FirstName = firstName, LastName= lastName };
            newEmployee.Id = _employees.Max(s => s.Id + 1);

            return newEmployee;
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return _employees;
        }
    }
}
