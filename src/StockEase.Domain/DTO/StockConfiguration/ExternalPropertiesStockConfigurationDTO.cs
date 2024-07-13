using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class ExternalPropertiesStockConfigurationDTO : BaseExternalPropertiesDTO<ExternalPropertiesStockConfigurationDTO>
    {
        public decimal MinimumStockAmount { get; private set; }
        public long ProductId { get; private set; }

        public ExternalPropertiesStockConfigurationDTO() { }

        public ExternalPropertiesStockConfigurationDTO(decimal minimumStockAmount, long productId)
        {
            MinimumStockAmount = minimumStockAmount;
            ProductId = productId;
        }
    }
}