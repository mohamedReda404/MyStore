
using AppStore.Products;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace AppStore.Categorys
{
    public class Category: BasicAggregateRoot<int>
    {
        public string Name { get; set; } =string.Empty;
        public string Description { get; set; } =string.Empty;
        public ICollection<Product>? Product { get; set; }
    }
}
