using Common;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class LmsDbContext : DbContext
    {
        public LmsDbContext(DbContextOptions options) :base(options)
        {  
        }

        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            //modelBuilder.ApplyConfiguration(new EntityConfiguration());

            
            //modelBuilder.Entity<Course>().HasIndex(x => x.Name);
            //modelBuilder.Entity<Course>().HasIndex(x => x.Topic);
            //modelBuilder.Entity<Course>().HasIndex(x => x.IsFree);
            //modelBuilder.Entity<Course>().Property(b => b.AverageRating).HasDefaultValue(0);

            //modelBuilder.Entity<Entity>().Property(b => b.Modified).ValueGeneratedOnAddOrUpdate();
            //modelBuilder.Entity<Entity>().Property(b => b.Created).HasDefaultValue(DateTime.Now);

        }
    }
}
