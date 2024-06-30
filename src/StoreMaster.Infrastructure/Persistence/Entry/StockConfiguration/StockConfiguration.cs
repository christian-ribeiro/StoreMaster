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
    }
}