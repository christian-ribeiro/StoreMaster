using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
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