using Class12Demo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class12Demo.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //IEnumerable<Movie> listOmovies = new IEnumerable<Movie>
            

            Movie movie = new Movie
            {
                Title = "Jurassic Park",
                ReleaseDate = 1993,
                Rating = "PG-13",
                RunTime = 127
            };


            
            List<Movie> movies = new List<Movie>() { movie };

            movies.Add(new Movie { Title = "Inception", ReleaseDate = 2010, Rating = "PG-13", RunTime = 300 });
            movies.Add(new Movie { Title = "Toy Story 3", ReleaseDate = 2010, Rating = "G", RunTime = 103 });



            //ViewData["movie"] = movie;
            //ViewData["Test"] = "Test";
            return View(movies);
            
        }

        public ViewResult Add()
        {
            return View();
        }
    }
}
