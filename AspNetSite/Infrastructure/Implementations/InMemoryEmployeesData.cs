using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetSite.Infrastructure.Interfaces;
using AspNetSite.Models;

namespace AspNetSite.Infrastructure.Implementations
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<Employee> _employees;
        public InMemoryEmployeesData ()
        {
            _employees = new List<Employee>()
            {
                new Employee(){Id = 1, FullName = "Журавский Н.В.", Post = "Зав.Склада"},
                new Employee(){Id = 2, FullName = "Горбовский Д.В.", Post = "Оператор"},
                new Employee(){Id = 3, FullName = "Сафронова О.С.", Post = "Оператор"}
            };
        }
        public void AddEmployee(Employee employee)
        {
            if (_employees.Count != 0)
                employee.Id = _employees.Max(x => x.Id) + 1;
            else
                employee.Id = 1;
            _employees.Add(employee);
        }

        public void DeletById(int Id)
        {
            var employee = GetEmployeeById(Id);
            if (employee != null)
                _employees.Remove(employee);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employees;
        }

        public Employee GetEmployeeById(int Id)
        {
            return _employees.FirstOrDefault(x => x.Id == Id);
        }
    }
}
