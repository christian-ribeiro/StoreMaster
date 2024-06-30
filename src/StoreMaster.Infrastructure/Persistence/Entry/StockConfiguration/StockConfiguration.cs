using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockConfiguration : BaseEntry<StockConfiguration>
    {
        public decimal MinimumStockAmount { get; private set; }

        public StockConfiguration() { }

        [JsonConstructor]
        public StockConfiguration(decimal minimumStockAmount)
        {
            MinimumStockAmount = minimumStockAmount;
        }

#nullable disable
        public static StockConfigurationDTO GetDTO(StockConfiguration stockconfiguration)
        {
            return new StockConfigurationDTO().Load(
                    new InternalPropertiesStockConfigurationDTO().SetInternalData(stockconfiguration.Id, stockconfiguration.CreationDate, stockconfiguration.ChangeDate),
                    new ExternalPropertiesStockConfigurationDTO(),
                    new AuxiliaryPropertiesStockConfigurationDTO()
                );
        }

        public static StockConfiguration GetEntry(StockConfigurationDTO dto)
        {
            return dto == null ? default : new StockConfiguration().SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
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