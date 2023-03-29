using Books.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Books.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        { 
        }

        public DbSet<Books.Models.Genre> Genre { get; set; } //<name-of-the-model>  
        public DbSet<Books.Models.Books> Books { get; set; } //Genre-name of the able(can be different)
        //public DbSet<Books.Models.Test> Test { get; set; }
    }
}
