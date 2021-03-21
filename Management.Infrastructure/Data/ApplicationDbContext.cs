using Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<CourseRegistrations> CourseRegistrations { get; set; }
        public DbSet<Log> Logs { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Lecturer>()
                .HasMany(x => x.Courses)
                .WithOne(x => x.Lecturer)
                .HasForeignKey(x => x.LecturerId);


            modelBuilder.Entity<CourseRegistrations>()
                .HasKey(x => new { x.Id });

        }

    }
}
