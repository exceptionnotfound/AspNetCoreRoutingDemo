using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreRoutingDemo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Sample(int id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}