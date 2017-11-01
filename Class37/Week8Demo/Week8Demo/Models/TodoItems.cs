using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week8Demo.Models
{
    public class TodoItems
    {
        public int Id { get; set; }
        [MinLength(3)]
        public string Task { get; set; }
        public bool IsComplete { get; set; }

    }
}
