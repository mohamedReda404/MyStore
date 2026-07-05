using AppStore.Categorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AppStore.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention();

            builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(AppStoreConsts.LengthName);

            builder.Property(x => x.Description)
               .HasMaxLength(AppStoreConsts.LengthDescription)
               .IsRequired();

            
        }
    }
}
