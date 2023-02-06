using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Dataaccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDbContext _Context = new TodoDbContext();
        public List<Author> GetAllAuthors()
        {
            return _Context.Authors.ToList();
           
        }

        public Author GetAthor(int id)
        {
            return _Context.Authors.Find(id);
        }
    }
}
