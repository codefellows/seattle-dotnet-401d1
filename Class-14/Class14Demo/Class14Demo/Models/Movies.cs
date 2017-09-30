using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class14Demo.Models
{
    public class Movies
    {

        public int ID { get; set; }

        [StringLength(30, MinimumLength =2)]
        [Required]
        public string Title { get; set; }

        [Range(1,240)]
        public int Runtime { get; set; }

        [Display(Name="Release Year")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseYear { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30)]
        [Required]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

    }
}
