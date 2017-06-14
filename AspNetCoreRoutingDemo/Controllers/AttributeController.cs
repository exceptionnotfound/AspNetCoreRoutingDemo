using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreRoutingDemo.Controllers
{
    [Route("users")]
    public class AttributeController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult ByID(int id)
        {
            ViewData["userID"] = id;
            return View();
        }

        [HttpGet("{dateOfBirth}")]
        public IActionResult ByDateOfBirth(DateTime dateOfBirth)
        {
            ViewData["dateOfBirth"] = dateOfBirth;
            return View();
        }
    }
}