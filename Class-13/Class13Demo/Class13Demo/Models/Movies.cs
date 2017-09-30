using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class13Demo.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }

        public decimal Price { get; set; }
    }
}
