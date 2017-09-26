using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class11Demo.Controllers
{
    public class MovieController : Controller
    {
        public string Index()
        {
            return "This is the index Action in the Movie Controller";
        }

        public string Find(string name, int year)
        {

            return $"Movie {name} was released in {year}";
        }

        public string Error()
        {
            return "Something went wrong (oh no!!!)";
        }
    }
}
