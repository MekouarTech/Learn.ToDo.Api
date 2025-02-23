﻿using Learn.ToDo.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.ToDo.Infrastructure.Data
{
    public class TodoContext : DbContext
    {
        private readonly static string MyConString = "Server=ServerName;Database=LearnTodoApiApp2;Trusted_Connection=True;TrustServerCertificate=True;";
        
        public TodoContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(MyConString);
        }

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<ToDoDetail> ToDoDetails { get; set; }
        public DbSet<ToDoCategory> ToDoCategories { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
