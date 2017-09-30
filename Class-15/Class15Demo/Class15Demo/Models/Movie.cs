using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class15Demo.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Range(30,400, ErrorMessage="Out of Range")]
        
        public int RunTime { get; set; }
        [Required(ErrorMessage = "Genre is required")]
        public string Genre { get; set; }
        [Display(Name ="Starring")]
        [Required]
        public string LeadStar { get; set; }
    }
}
