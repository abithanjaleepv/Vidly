using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Vidly.Models;

namespace Vidly
{
    public class MyDbContext : DbContext
    {
        // Define properties that represent tables in the database
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Orders { get; set; }
    }

}