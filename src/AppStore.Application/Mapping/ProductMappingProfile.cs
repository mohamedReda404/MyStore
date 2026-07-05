using AppStore.Products;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;

namespace AppStore.Mapping;

[Mapper]
public partial class ProductMappingProfile
    : MapperBase<Product, ProductsResponseDto>
{
    public override partial ProductsResponseDto Map(Product source);
    public override partial void Map(Product source, ProductsResponseDto destination);
}