using StoreMaster.Arguments.Enums;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class InternalPropertiesStockMovementDTO : BaseInternalPropertiesDTO<InternalPropertiesStockMovementDTO>
    {
        public EnumStockMovementType StockMovementType { get; private set; }

        public InternalPropertiesStockMovementDTO() { }

        public InternalPropertiesStockMovementDTO(EnumStockMovementType stockMovementType)
        {
            StockMovementType = stockMovementType;
        }
    }
}