using Class19Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class19Demo.Controllers
{
    public class ProductsController : Controller
    {
      public IRepository _repo;

        public ProductsController()
        {
        }

        public ProductsController(IRepository repository)
        {
            _repo = repository;
        }

        public ViewResult Index()
        {
            return View(_repo.Products);

        }
    }
}
