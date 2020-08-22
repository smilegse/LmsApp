using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasIndex(x => x.CourseName);
            builder.HasIndex(x => x.Topic);
            builder.HasIndex(x => x.IsFree);
            builder.Property(b => b.AverageRating).HasDefaultValue(0.00);
            builder.Property(b => b.EnrolledCount).HasDefaultValue(0);
            builder.Property(b => b.RegularPrice).HasDefaultValue(0.00);
            builder.Property(b => b.DiscountPrice).HasDefaultValue(0.00);
            builder.Property(b => b.IsFree).HasDefaultValue(false);
            builder.Property(b => b.TotalDurationHour).HasDefaultValue(0);
            builder.Property(b => b.TotalLectureCount).HasDefaultValue(0);
            builder.Property(b => b.ViewCount).HasDefaultValue(0);

            builder.Property(b => b.Modified).ValueGeneratedOnAddOrUpdate();
            

            //builder.Property(g => g.Name).IsRequired().HasMaxLength(50);
            //builder.Property(g => g.Price).IsRequired().HasPrecision(8, 2);
            //builder.Property(g => g.CategoryID).IsRequired();
        }
    }
}
