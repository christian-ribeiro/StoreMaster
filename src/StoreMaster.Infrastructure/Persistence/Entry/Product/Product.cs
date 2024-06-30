using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class Product : BaseEntry<Product>
    {
        public long ProductCategoryId { get; private set; }
        public virtual ProductCategory ProductCategory { get; private set; }

        public Product() { }

        [JsonConstructor]
        public Product(long productCategoryId, ProductCategory productCategory)
        {
            ProductCategoryId = productCategoryId;
            ProductCategory = productCategory;
        }
    }
}