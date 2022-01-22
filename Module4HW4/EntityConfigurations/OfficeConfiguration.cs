using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntityConfigurations
{
   public class OfficeConfiguration : IEntityTypeConfiguration<OfficeEntity>
    {
        public void Configure(EntityTypeBuilder<OfficeEntity> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Office").HasKey(o => o.OfficeId);
            entityTypeBuilder.Property(o => o.OfficeId).HasColumnName("OfficeId").ValueGeneratedOnAdd();
            entityTypeBuilder.Property(o => o.Title).IsRequired().HasColumnName("Title").HasMaxLength(100);
            entityTypeBuilder.Property(o => o.Location).IsRequired().HasColumnName("Location").HasMaxLength(100);
        }
    }
}
