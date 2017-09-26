using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class11Demo.Controllers
{
    [Route("Error")]
    public class ErrorController
    {
        [Route("Support")]
        public string Index()
        {
            return "This is your error page, please contact support";
        }
    }
}
