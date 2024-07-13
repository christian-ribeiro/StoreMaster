using StockEase.Domain.DTO;
using StockEase.Infrastructure.Persistence.Entry.Base;

namespace StockEase.Infrastructure.Persistence.Entry
{
    public class Product : BaseEntry<Product>
    {
        public string Description { get; private set; }
        public long ProductCategoryId { get; private set; }

        #region Virtual Properties
        #region Internal
        public virtual ProductCategory? ProductCategory { get; private set; }
        #endregion
        #region External
        public virtual StockConfiguration? StockConfiguration { get; private set; }
        public virtual List<StockMovement> ListStockMovement { get; private set; }
        #endregion
        #endregion

        public Product() { }

        public Product(string description, long productCategoryId, ProductCategory? productCategory)
        {
            Description = description;
            ProductCategoryId = productCategoryId;
            ProductCategory = productCategory;
        }

#nullable disable
        public static ProductDTO GetDTO(Product product)
        {
            return product == null ? default : new ProductDTO().Load(
                    new InternalPropertiesProductDTO().SetInternalData(product.Id, product.CreationDate, product.ChangeDate, product.CreationUserId, product.ChangeUserId),
                    new ExternalPropertiesProductDTO(product.Description, product.ProductCategoryId),
                    new AuxiliaryPropertiesProductDTO(product.ProductCategory).SetInternalData(product.CreationUser, product.ChangeUser));
        }

        public static Product GetEntry(ProductDTO dto)
        {
            return dto == null ? default : new Product(dto.ExternalPropertiesDTO.Description, dto.ExternalPropertiesDTO.ProductCategoryId, dto.AuxiliaryPropertiesDTO.ProductCategory)
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate, dto.InternalPropertiesDTO.CreationUserId, dto.InternalPropertiesDTO.ChangeUserId, dto.AuxiliaryPropertiesDTO.CreationUser, dto.AuxiliaryPropertiesDTO.ChangeUser);
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