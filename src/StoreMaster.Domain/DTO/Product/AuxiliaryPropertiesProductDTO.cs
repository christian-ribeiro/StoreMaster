using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class AuxiliaryPropertiesProductDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesProductDTO>
    {
        public ProductCategoryDTO ProductCategory { get; private set; }

        public AuxiliaryPropertiesProductDTO() { }

        public AuxiliaryPropertiesProductDTO(ProductCategoryDTO productCategory)
        {
            ProductCategory = productCategory;
        }
    }
}