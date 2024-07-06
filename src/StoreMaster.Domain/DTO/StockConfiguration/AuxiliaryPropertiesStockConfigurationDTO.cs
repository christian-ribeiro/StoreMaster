using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class AuxiliaryPropertiesStockConfigurationDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesStockConfigurationDTO>
    {
        public ProductDTO Product { get; private set; }

        public AuxiliaryPropertiesStockConfigurationDTO() { }

        public AuxiliaryPropertiesStockConfigurationDTO(ProductDTO product)
        {
            Product = product;
        }
    }
}