using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class12Demo
{
    //[Route("Movies")]
    public class MovieController : Controller
    {
        [Route("Movies/Home")]
        public string Index()
        {
            return "Input a string, put the name and year in the browser";
        }

        [Route("NewMovie")] 
        public string Add(string name, int year)
        {
            return $"The movie {name} was released in {year}.";
        }

    }
}
