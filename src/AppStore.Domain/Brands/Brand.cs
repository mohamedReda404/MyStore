
using AppStore.Products;

namespace AppStore.Brands
{
    public class Brand : BasicAggregateRoot<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Product ?Product { get; set; }
        public int ProductId { get; set; }
    }
}
