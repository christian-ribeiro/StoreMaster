using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class InternalPropertiesStockMovementDTO : BaseInternalPropertiesDTO<InternalPropertiesStockMovementDTO>
    {
        public long StockMovementTypeId { get; private set; }

        public InternalPropertiesStockMovementDTO() { }

        public InternalPropertiesStockMovementDTO(long stockMovementTypeId)
        {
            StockMovementTypeId = stockMovementTypeId;
        }
    }
}