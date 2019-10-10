using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSite.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ActionResult Index()
        {
            ViewBag.Title = "Домашняя страница";
            return View();
        }

        [Route("404")]
        public ActionResult Error()
        {
            ViewBag.Title = "Ошибка 404";
            return View();
        }
    }
}