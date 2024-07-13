using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class ExternalPropertiesStockMovementDTO : BaseExternalPropertiesDTO<ExternalPropertiesStockMovementDTO>
    {
        public decimal Quantity { get; private set; }
        public long ProductId { get; private set; }
        public long StockMovementTypeId { get; private set; }

        public ExternalPropertiesStockMovementDTO() { }

        public ExternalPropertiesStockMovementDTO(decimal quantity, long productId, long stockMovementTypeId)
        {
            Quantity = quantity;
            ProductId = productId;
            StockMovementTypeId = stockMovementTypeId;
        }
    }
}