using AppStore.Products;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;

namespace AppStore.Mapping;

[Mapper]
public partial class ProductDTOMappingProfile
    : MapperBase<ProductRequestDto, Product>
{
    
    public override partial Product Map( ProductRequestDto destination);
    public override partial void Map(ProductRequestDto destination, Product source);
}