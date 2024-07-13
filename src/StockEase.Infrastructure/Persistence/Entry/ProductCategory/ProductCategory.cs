using StockEase.Domain.DTO;
using StockEase.Infrastructure.Persistence.Entry.Base;

namespace StockEase.Infrastructure.Persistence.Entry
{
    public class ProductCategory : BaseEntry<ProductCategory>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        #region Virtual Properties
        #region External
        public virtual List<Product> ListProduct { get; private set; }
        #endregion
        #endregion
        public ProductCategory() { }

        public ProductCategory(string code, string description)
        {
            Code = code;
            Description = description;
        }

#nullable disable
        public static ProductCategoryDTO GetDTO(ProductCategory productCategory)
        {
            return productCategory == null ? default : new ProductCategoryDTO().Load(
                    new InternalPropertiesProductCategoryDTO().SetInternalData(productCategory.Id, productCategory.CreationDate, productCategory.ChangeDate, productCategory.CreationUserId, productCategory.ChangeUserId),
                    new ExternalPropertiesProductCategoryDTO(productCategory.Code, productCategory.Description),
                    new AuxiliaryPropertiesProductCategoryDTO().SetInternalData(productCategory.CreationUser, productCategory.ChangeUser));
        }

        public static ProductCategory GetEntry(ProductCategoryDTO dto)
        {
            return dto == null ? default : new ProductCategory(dto.ExternalPropertiesDTO.Code, dto.ExternalPropertiesDTO.Description)
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate, dto.InternalPropertiesDTO.CreationUserId, dto.InternalPropertiesDTO.ChangeUserId, dto.AuxiliaryPropertiesDTO.CreationUser, dto.AuxiliaryPropertiesDTO.ChangeUser);
        }

        public static implicit operator ProductCategoryDTO(ProductCategory productcategory)
        {
            return GetDTO(productcategory);
        }

        public static implicit operator ProductCategory(ProductCategoryDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}