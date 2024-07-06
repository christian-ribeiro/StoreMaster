using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
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

        public ProductCategory(string code, string description, List<Product> listProduct)
        {
            Code = code;
            Description = description;
            ListProduct = listProduct;
        }

#nullable disable
        public static ProductCategoryDTO GetDTO(ProductCategory productCategory)
        {
            return new ProductCategoryDTO().Load(
                    new InternalPropertiesProductCategoryDTO().SetInternalData(productCategory.Id, productCategory.CreationDate, productCategory.ChangeDate),
                    new ExternalPropertiesProductCategoryDTO(productCategory.Code, productCategory.Description),
                    new AuxiliaryPropertiesProductCategoryDTO()
                );
        }

        public static ProductCategory GetEntry(ProductCategoryDTO dto)
        {
            return dto == null ? default : new ProductCategory(dto.ExternalPropertiesDTO.Code, dto.ExternalPropertiesDTO.Description, default).SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
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