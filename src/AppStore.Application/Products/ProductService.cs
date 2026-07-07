using AppStore.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Caching;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace AppStore.Products
{
    public class ProductService : CrudAppService<Product, ProductsResponseDto, int, PagedAndSortedResultRequestDto, ProductRequestDto>, IProductService
    {
        private readonly IDistributedCache<ProductsResponseDto, int> _destributedChache;
        private readonly IRepository<Product, int> _repository;
        public ProductService(IRepository<Product, int> repository, 
            IDistributedCache<ProductsResponseDto, int> chache ): base(repository)
        {
            _destributedChache= chache;

            GetPolicyName = AppStorePermissions.ProductGroupName;

            GetListPolicyName = AppStorePermissions.List;

            CreatePolicyName = AppStorePermissions.Create;

            UpdatePolicyName = AppStorePermissions.Edit;

            DeletePolicyName = AppStorePermissions.Delete;
            
        }
        [Authorize(AppStorePermissions.List)]
        public async Task<int> GetProductsCountAsync()
        {
            var count = await Repository.CountAsync();
            return count;
        }

        public override async Task<ProductsResponseDto> GetAsync(int id)
        {
            var cachedProduct = await _destributedChache.GetAsync(id);

            if (cachedProduct != null)
            {
                return cachedProduct;
            }
           

            var product = await base.GetAsync(id);
            await _destributedChache.SetAsync(id, product);
            return product;
        }
    }
}
