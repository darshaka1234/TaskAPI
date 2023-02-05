using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoServices _todoServices;

        public TodosController()
        {
            _todoServices = new TodoServices();
        }
        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var todos = _todoServices.AllTodos();
            if(id is null) return Ok(todos);
            var MyTodos = todos.Where(t => t.Id == id);
            return Ok(MyTodos);
        }
    
    }
    
}

