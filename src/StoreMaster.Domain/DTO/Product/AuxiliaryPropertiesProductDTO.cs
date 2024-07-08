using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
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