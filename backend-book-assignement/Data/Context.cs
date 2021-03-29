using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_book_assignement.Models;


namespace backend_book_assignement.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Books> Book { get; set; }
        public DbSet<User> User { get; set; }

    }
}
