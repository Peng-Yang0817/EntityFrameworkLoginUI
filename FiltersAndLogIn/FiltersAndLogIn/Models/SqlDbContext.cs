using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace FiltersAndLogIn.Models
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("name=SqlConnection") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}