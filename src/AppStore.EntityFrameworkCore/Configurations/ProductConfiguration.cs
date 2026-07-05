using AppStore.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AppStore.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ConfigureByConvention();

            builder.Property(x => x.Name)
                .HasMaxLength(AppStoreConsts.LengthName)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(AppStoreConsts.LengthDescription)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();

           
           
        }
    }
}
