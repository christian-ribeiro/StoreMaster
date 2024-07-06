using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class ExternalPropertiesStockMovementDTO : BaseExternalPropertiesDTO<ExternalPropertiesStockMovementDTO>
    {
        public long ProductId { get; private set; }
        public long StockMovementTypeId { get; private set; }

        public ExternalPropertiesStockMovementDTO() { }

        public ExternalPropertiesStockMovementDTO(long productId, long stockMovementTypeId)
        {
            ProductId = productId;
            StockMovementTypeId = stockMovementTypeId;
        }
    }
}