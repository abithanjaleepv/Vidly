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
        public MyDbContext() : base("MyContextDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<
            MyDbContext, Vidly.Migrations.Configuration>("MyContextDB"));
        }
        // Define properties that represent tables in the database
       // public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals  { get; set; }

    }

   

}