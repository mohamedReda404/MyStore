
using AppStore.Brands;
using AppStore.Categorys;
using System.Collections.Generic;

namespace AppStore.Products
{
    public class Product:FullAuditedAggregateRoot<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public long Price { get; set; } 
        public ICollection<Brand> ?brands { get; set; }
        public int CategoryId { get; set; }
        public Category ?category { get; set; }
    }
}
