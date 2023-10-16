using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;

namespace CodeFirst.Data
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext (DbContextOptions<CodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<CodeFirst.Models.Car> Car { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Name = "Pepe",
                    Age = 30,
                    Note = 10,
                    ExamDate = DateTime.Now
                },
                new Car
                {
                    Id = 2,
                    Name = "Luis",
                    Age = 35,
                    Note = 7,
                    ExamDate = DateTime.Now
                },
                new Car
                {
                    Id = 3,
                    Name = "Ana",
                    Age = 29,
                    Note = 8.4m,
                    ExamDate = DateTime.Now
                }
                );
        }
    }
}
