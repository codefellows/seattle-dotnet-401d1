using Class26Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class26Demo.Controllers
{
    public class HomeController : Controller
    {

        //private field, used for Dependendcy Injection
        private readonly Class26DemoContext _context;


        //Constructor for Home Controller - a DBContext is required
        public HomeController(Class26DemoContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            // Calling to the CMS table in the database and getting the content for ID 1
            var result = _context.CMS.Where(c => c.ID == 1);

            return View(result.ToList());
        }
    }
}
