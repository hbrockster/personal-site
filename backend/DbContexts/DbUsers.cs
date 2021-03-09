using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.DbContexts
{
    public class DbUsers : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite("Data Source = Users.db;");
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Name = "Hunter Brock", CellPhoneNumber = "(850)612-3487", Age = 26, Email = "hbrockster13@gmail.com"}
            );
        }
    }
}
