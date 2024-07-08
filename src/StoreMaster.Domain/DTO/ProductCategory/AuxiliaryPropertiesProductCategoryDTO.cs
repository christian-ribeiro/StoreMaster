using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class AuxiliaryPropertiesProductCategoryDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesProductCategoryDTO>
    {
        public List<ProductDTO> ListProduct { get; private set; }

        public AuxiliaryPropertiesProductCategoryDTO() { }

        public AuxiliaryPropertiesProductCategoryDTO(List<ProductDTO> listProduct)
        {
            ListProduct = listProduct;
        }
    }
}