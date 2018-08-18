using BookStore_MVC.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}