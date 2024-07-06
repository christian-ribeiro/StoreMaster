using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockConfiguration : BaseEntry<StockConfiguration>
    {
        public decimal MinimumStockAmount { get; private set; }
        public long ProductId { get; set; }

        #region Virtual Properties
        #region Internal
        public virtual Product Product { get; set; }
        #endregion
        #endregion
        public StockConfiguration() { }

        public StockConfiguration(decimal minimumStockAmount, long productId, Product product)
        {
            MinimumStockAmount = minimumStockAmount;
            ProductId = productId;
            Product = product;
        }

#nullable disable
        public static StockConfigurationDTO GetDTO(StockConfiguration stockconfiguration)
        {
            return stockconfiguration == null ? default : new StockConfigurationDTO().Load(
                    new InternalPropertiesStockConfigurationDTO().SetInternalData(stockconfiguration.Id, stockconfiguration.CreationDate, stockconfiguration.ChangeDate),
                    new ExternalPropertiesStockConfigurationDTO(stockconfiguration.MinimumStockAmount, stockconfiguration.ProductId),
                    new AuxiliaryPropertiesStockConfigurationDTO());
        }

        public static StockConfiguration GetEntry(StockConfigurationDTO dto)
        {
            return dto == null ? default : new StockConfiguration(dto.ExternalPropertiesDTO.MinimumStockAmount, dto.ExternalPropertiesDTO.ProductId, dto.AuxiliaryPropertiesDTO.Product).SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator StockConfigurationDTO(StockConfiguration stockconfiguration)
        {
            return GetDTO(stockconfiguration);
        }

        public static implicit operator StockConfiguration(StockConfigurationDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}