using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week8Demo.Data;

namespace Week8Demo.Models
{
    public class TaskList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<TodoItems> Tasks { get; set; }

        //public List<TodoItems> GetAllTasks(int id)
        //{
        //    List<TodoItems> myTasks = new List<TodoItems>();

        //    myTasks = _context.TodoItems.Where(i => i.ListId == id).ToList();

        //    return myTasks;

        //    //return 
        //}
    }

 
}
