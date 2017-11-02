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
    public class ListsController : ControllerBase
    {
        private readonly TodoDbContext _context;

        public ListsController(TodoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TaskList> Get()
        {
            return _context.TaskList;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            // We are getting the list that is associated with the id specified. 
            var getList = _context.TaskList.FirstOrDefault(h => h.ID == id);

            // A call to the todo items and get all items where ListId == id specified

            TaskList task = new TaskList();

            task.Tasks = _context.TodoItems.Where(i => i.ListId == id).ToList();
            task.Name = getList.Name;
            
            return Ok(task);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TaskList list)
        {
            await _context.TaskList.AddAsync(list);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = list.ID }, list);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody] TaskList list)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var check = _context.TaskList.FirstOrDefault(i => i.ID == id);

            if (check != null)
            {
                check.Name = list.Name;
                _context.Update(check);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest();

        }



        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _context.TaskList.FirstOrDefault(d => d.ID == id);

            if (result != null)
            {
                _context.TaskList.Remove(result);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest();

        }
    }
}
