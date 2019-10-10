using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetSite.Infrastructure.Interfaces;
using AspNetSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSite.Controllers
{
    [Route("users")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employeesData;
        public EmployeesController (IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }
        public IActionResult Index()
        {
            return View(_employeesData.GetAllEmployee());
        }

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var model = _employeesData.GetEmployeeById(id);
            if(ReferenceEquals(null, model))
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(Employee model)
        {
            return View();
        }

        public IActionResult Create()
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}