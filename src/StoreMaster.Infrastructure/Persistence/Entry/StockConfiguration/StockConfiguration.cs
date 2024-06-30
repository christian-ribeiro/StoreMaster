using StoreMaster.Arguments.Arguments;
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
        public static implicit operator OutputStockConfiguration(StockConfiguration stockconfiguration)
        {
            return stockconfiguration == null ? default : new OutputStockConfiguration(stockconfiguration.MinimumStockAmount).SetInternalData(stockconfiguration.Id, stockconfiguration.CreationDate, stockconfiguration.ChangeDate);
        }

        public static implicit operator StockConfiguration(OutputStockConfiguration output)
        {
            return output == null ? default : new StockConfiguration(output.MinimumStockAmount).SetInternalData(output.Id, output.CreationDate, output.ChangeDate);
        }
#nullable enable
    }
}