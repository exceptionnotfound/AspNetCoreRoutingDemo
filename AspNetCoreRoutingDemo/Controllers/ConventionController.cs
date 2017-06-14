using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreRoutingDemo.Controllers
{
    public class ConventionController : Controller
    {
        public IActionResult AllBlogs() //An example of using a single convention route for multiple actions.
        {
            return View("AllBlogs");
        }

        public IActionResult Index(int blogID)
        {
            ViewData["blogID"] = blogID;
            return View();
        }

        public IActionResult BlogPost(int blogID, int postID)
        {
            ViewData["blogID"] = blogID;
            ViewData["postID"] = postID;
            return View();
        }
    }
}