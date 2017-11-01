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

        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<TodoItems> Get()
        {
            return _context.TodoItems;

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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post([FromBody]TodoItems item)
        {
            await _context.AddAsync(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = item.Id }, item);
        }

        //Put
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody]TodoItems item)
        {
            if(!ModelState.IsValid)
            {
              return BadRequest(ModelState);
            }
            var check = _context.TodoItems.FirstOrDefault(i => i.Id == id);
            if(check != null)
            {
                //do the thing.
                // _context.Update(item);
                check.Task = item.Task;
                check.IsComplete = item.IsComplete;
                _context.Update(check);
              await _context.SaveChangesAsync();
                return Ok();

            }
            return BadRequest();
        }

        //Delete
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _context.TodoItems.FirstOrDefault(h => h.Id == id);
            if(result != null)
            {
                _context.TodoItems.Remove(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest();
        }


    }
}
