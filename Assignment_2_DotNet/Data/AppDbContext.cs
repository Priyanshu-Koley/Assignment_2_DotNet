﻿using Assignment_2_DotNet.Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace Assignment_2_DotNet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
