using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTodos()
        {
            var todos = AllTodos();
            return Ok(todos);
        }
        private static List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "todo1",
                Description = "just todo 1",
                Created = DateTime.Now,
                Due = DateTime.Now.Date.AddDays(1),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "todo2",
                Description = "just todo 2",
                Created = DateTime.Now,
                Due = DateTime.Now.Date.AddDays(2),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            return todos;
        }
    }
    
}

