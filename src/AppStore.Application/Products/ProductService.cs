using AppStore.Permissions;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AppStore.Products
{
    public class ProductService : CrudAppService<Product, ProductsResponseDto, int, PagedAndSortedResultRequestDto, ProductRequestDto, ProductRequestDto> ,IProductService
    {
        public ProductService(IRepository<Product, int> repository) : base(repository)
        {
            GetPolicyName = AppStorePermissions.ProductGroupName;

            GetListPolicyName = AppStorePermissions.List;

            CreatePolicyName = AppStorePermissions.Create;

            UpdatePolicyName = AppStorePermissions.Edit;

            DeletePolicyName = AppStorePermissions.Delete;
        }
    }
}
