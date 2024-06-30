using StoreMaster.Arguments.Arguments;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class Product : BaseEntry<Product>
    {
        public long ProductCategoryId { get; private set; }
        public virtual ProductCategory? ProductCategory { get; private set; }

        public Product() { }

        [JsonConstructor]
        public Product(long productCategoryId, ProductCategory? productCategory)
        {
            ProductCategoryId = productCategoryId;
            ProductCategory = productCategory;
        }

#nullable disable
        public static implicit operator OutputProduct(Product product)
        {
            return product == null ? default : new OutputProduct(product.ProductCategoryId, product.ProductCategory).SetInternalData(product.Id, product.CreationDate, product.ChangeDate);
        }

        public static implicit operator Product(OutputProduct output)
        {
            return output == null ? default : new Product(output.ProductCategoryId, output.ProductCategory).SetInternalData(output.Id, output.CreationDate, output.ChangeDate);
        }
#nullable enable
    }
}