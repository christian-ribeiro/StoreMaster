using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class AuxiliaryPropertiesStockMovementDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesStockMovementDTO>
    {
        public ProductDTO Product { get; private set; }
        public StockMovementTypeDTO StockMovementType { get; private set; }

        public AuxiliaryPropertiesStockMovementDTO() { }

        public AuxiliaryPropertiesStockMovementDTO(ProductDTO product, StockMovementTypeDTO stockMovementType)
        {
            Product = product;
            StockMovementType = stockMovementType;
        }
    }
}