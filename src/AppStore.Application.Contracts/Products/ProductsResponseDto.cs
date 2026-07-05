using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AppStore.Products
{
    public class ProductsResponseDto:FullAuditedEntityDto<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public long Price { get; set; }
    }
}
