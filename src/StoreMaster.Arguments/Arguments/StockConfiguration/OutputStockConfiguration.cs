using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputStockConfiguration : BaseOutput<OutputStockConfiguration>
    {
        public decimal MinimumStockAmount { get; set; }

        public OutputStockConfiguration() { }

        public OutputStockConfiguration(decimal minimumStockAmount)
        {
            MinimumStockAmount = minimumStockAmount;
        }
    }
}