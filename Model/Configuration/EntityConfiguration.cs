using Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Model.Configuration
{
    public class EntityConfiguration: IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.Property(b => b.Modified).ValueGeneratedOnAddOrUpdate();
            builder.Property(b => b.Created).HasDefaultValue(DateTime.Now);
        }
    }
}
