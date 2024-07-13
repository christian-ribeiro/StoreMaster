using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
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