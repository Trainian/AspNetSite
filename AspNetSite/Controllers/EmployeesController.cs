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

        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = _employeesData.GetEmployeeById(id);
            if(ReferenceEquals(null, model))
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpGet]
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            Employee model;
            if (id > 0)
            {
                model = _employeesData.GetEmployeeById(id.Value);
                if (ReferenceEquals(null, model))
                    return NotFound();
                return View(model);
            }
            else
                model = new Employee();
            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(Employee model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    var dbmodel = _employeesData.GetEmployeeById(model.Id);

                    if (ReferenceEquals(null, dbmodel))
                        return NotFound();

                    dbmodel.FullName = model.FullName;
                    dbmodel.Post = model.Post;
                }
                else
                {
                    _employeesData.AddEmployee(model);
                }

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        [Route("delete/{id?}")]
        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                var model = _employeesData.GetEmployeeById(id);
                if (ReferenceEquals(null, model))
                    return NotFound();
                _employeesData.DeletById(id);
            }
            else NotFound();
            return RedirectToAction(nameof(Index));
        }
    }
}