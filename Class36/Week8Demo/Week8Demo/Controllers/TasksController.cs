using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week8Demo.Data;
using Week8Demo.Models;

namespace Week8Demo.Controllers
{
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly TodoDbContext _context;

        public TasksController(TodoDbContext context)
        {
            _context = context;
        }
        //Get
        [HttpGet("{id:int?}")]
        public IActionResult Get(int id)
        {
            var result = _context.TodoItems.FirstOrDefault(h => h.Id == id);
            return Ok(result);
        }

        //Post
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]TodoItems item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = item.Id }, item);
        }

        //Put

        //Delete

    }
}
