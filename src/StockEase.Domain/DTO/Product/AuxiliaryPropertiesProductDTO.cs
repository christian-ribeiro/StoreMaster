using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class AuxiliaryPropertiesProductDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesProductDTO>
    {
        #region Virtual Properties
        #region Internal
        public ProductCategoryDTO ProductCategory { get; private set; }
        #endregion
        #endregion

        public AuxiliaryPropertiesProductDTO() { }

        public AuxiliaryPropertiesProductDTO(ProductCategoryDTO productCategory)
        {
            ProductCategory = productCategory;
        }
    }
}