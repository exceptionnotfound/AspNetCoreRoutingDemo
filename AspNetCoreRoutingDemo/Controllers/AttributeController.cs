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
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult ByID(int id)
        {
            ViewData["userID"] = id;
            return View();
        }

        [HttpGet("{dateOfBirth}/all")]
        public IActionResult ByDateOfBirth(DateTime dateOfBirth)
        {
            ViewData["dateOfBirth"] = dateOfBirth;
            return View();
        }

        [HttpPost("search/byDateOfBirth")]
        public IActionResult SearchByDateOfBirth(DateTime dateOfBirth)
        {
            return RedirectToAction("ByDateOfBirth", new { dateOfBirth = dateOfBirth.ToString("yyyy-MM-dd") });
        }

        [HttpPost("search/byID/")]
        public IActionResult SearchByID(int id)
        {
            return RedirectToAction("ByID", new { id = id });
        }
    }
}