using AspNetSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetSite.Infrastructure.Interfaces
{
    public interface IEmployeesData
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeById (int Id);
        void AddEmployee(Employee employee);
        void DeletById(int Id);
    }
}
