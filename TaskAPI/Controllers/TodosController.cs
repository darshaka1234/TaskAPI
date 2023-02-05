using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]   
        public IActionResult Todos()
        {
            var todos = new String[] { "task1", "task2", "task3" };
            return Ok(todos);
        }
    }
}
