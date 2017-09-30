using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class13Demo.Controllers
{
    public class ErrorController : Controller
    {
       // [Route("Error")]
        public ViewResult Index()
        {
            string errorMessage = "Something went wrong!";
            ViewData["msg"] = errorMessage;
            return View("Index",errorMessage);
        }
    }
}
