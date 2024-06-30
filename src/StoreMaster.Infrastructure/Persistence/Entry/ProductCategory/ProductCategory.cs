using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.Text.Json.Serialization;

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

        [JsonConstructor]
        public ProductCategory(string code, string description, List<Product> listProduct)
        {
            Code = code;
            Description = description;
            ListProduct = listProduct;
        }

#nullable disable
        public static ProductCategoryDTO GetDTO(ProductCategory productcategory)
        {
            return new ProductCategoryDTO().Load(
                    new InternalPropertiesProductCategoryDTO().SetInternalData(productcategory.Id, productcategory.CreationDate, productcategory.ChangeDate),
                    new ExternalPropertiesProductCategoryDTO(),
                    new AuxiliaryPropertiesProductCategoryDTO()
                );
        }

        public static ProductCategory GetEntry(ProductCategoryDTO dto)
        {
            return dto == null ? default : new ProductCategory().SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
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