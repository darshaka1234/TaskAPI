using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.Dataaccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author {Id = 1, FullName="saman"},
                new Author {Id= 2, FullName="pahan"},
                new Author {Id= 3, FullName="laman"},
                new Author {Id= 4, FullName="nisan"}
            });
           
            modelBuilder.Entity<Todo>().HasData(new Todo[]{
                new Todo{
                Id = 1,
                Title = "todo1",
                Description = "just todo 1 from database",
                Created = DateTime.Now,
                Due = DateTime.Now.Date.AddDays(1),
                Status = TodoStatus.New,
                AuthorId= 1,
                },
                new Todo{
                Id = 2,
                Title = "todo1",
                Description = "just todo 2 from database",
                Created = DateTime.Now,
                Due = DateTime.Now.Date.AddDays(1),
                Status = TodoStatus.New,
                AuthorId= 3,
                },
                new Todo{
                Id = 3,
                Title = "todo1",
                Description = "just todo 3 from database",
                Created = DateTime.Now,
                Due = DateTime.Now.Date.AddDays(1),
                Status = TodoStatus.New,
                AuthorId= 1,
                },
                new Todo{
                Id = 4,
                Title = "todo1",
                Description = "just todo 4 from database",
                Created = DateTime.Now,
                Due = DateTime.Now.Date.AddDays(1),
                Status = TodoStatus.New,
                AuthorId= 3,
                },
            });
        }
    }
}
