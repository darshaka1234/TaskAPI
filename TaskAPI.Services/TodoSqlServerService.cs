using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Dataaccess;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoSqlServerService : ItodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }
    }
}
