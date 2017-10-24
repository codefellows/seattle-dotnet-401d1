using class28Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class28Demo.Controllers
{
    public class HomeController : Controller
    {
       private readonly class28DemoContext _context;

        public HomeController(class28DemoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.CMS.Where(c => c.ID == 1);
            return View(result.ToList());
        }
    }
}
