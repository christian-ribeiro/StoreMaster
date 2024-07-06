using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class AuxiliaryPropertiesStockMovementDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesStockMovementDTO>
    {
        public StockMovementTypeDTO StockMovementType { get; private set; }

        public AuxiliaryPropertiesStockMovementDTO() { }

        public AuxiliaryPropertiesStockMovementDTO(StockMovementTypeDTO stockMovementType)
        {
            StockMovementType = stockMovementType;
        }
    }
}