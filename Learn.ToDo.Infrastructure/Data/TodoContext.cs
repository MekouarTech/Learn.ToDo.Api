using Learn.ToDo.Infrastructure.Models;
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
        private readonly static string MyConString = "Server=DESKTOP-TKBJLN8\\SQLEXPRESS;Database=LearnTodoApiApp2;Trusted_Connection=True;TrustServerCertificate=True;";
        //"Server=DESKTOP-TKBJLN8\\SQLEXPRESS;Database=LearnTodoApiApp;User=username;Password=123456789Aa;TrustServerCertificate=True;";
        public TodoContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(MyConString);
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserDetail>().HasKey(x=> x.Id);
            modelBuilder.Entity<ToDoDetail>().HasKey(x=> x.Id);
            modelBuilder.Entity<ToDoCategory>().HasKey(x=> x.Id);
            modelBuilder.Entity<Category>().HasKey(x=> x.Id);
        }*/

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<ToDoDetail> ToDoDetails { get; set; }
        public DbSet<ToDoCategory> ToDoCategories { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
