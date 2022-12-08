﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=CoreBlogApiDb; integrated security=true;");
        } 
        public DbSet<Employee> Employees { get; set; }
        
    }
}
