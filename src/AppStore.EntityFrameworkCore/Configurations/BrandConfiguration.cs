using AppStore.Brands;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AppStore.Configurations
{
    internal class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ConfigureByConvention();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(AppStoreConsts.LengthName);

            builder.Property(x => x.Description)
               .HasMaxLength(AppStoreConsts.LengthDescription)
               .IsRequired();

            builder.HasOne(x => x.Product)
                .WithMany(x => x.brands)
                 .HasForeignKey(f=>f.ProductId);
        }
    }
}
