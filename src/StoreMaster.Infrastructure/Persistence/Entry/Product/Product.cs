using StoreMaster.Domain.DTO;
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
        public static ProductDTO GetDTO(Product product)
        {
            return new ProductDTO().Load(
                    new InternalPropertiesProductDTO().SetInternalData(product.Id, product.CreationDate, product.ChangeDate),
                    new ExternalPropertiesProductDTO(product.ProductCategoryId),
                    new AuxiliaryPropertiesProductDTO(product.ProductCategory)
                );
        }

        public static Product GetEntry(ProductDTO dto)
        {
            return dto == null ? default : new Product().SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator ProductDTO(Product product)
        {
            return GetDTO(product);
        }

        public static implicit operator Product(ProductDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}