using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AppStore.Products
{
    public interface IProductService:ICrudAppService<ProductsResponseDto
        , int,
        PagedAndSortedResultRequestDto
        , ProductRequestDto
        , ProductRequestDto>
    {

    }
}
