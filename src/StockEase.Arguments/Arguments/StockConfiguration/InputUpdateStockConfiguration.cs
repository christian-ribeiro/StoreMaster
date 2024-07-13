using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputUpdateStockConfiguration : BaseInputUpdate<InputUpdateStockConfiguration>
    {
        public decimal MinimumStockAmount { get; set; }

        public InputUpdateStockConfiguration(decimal minimumStockAmount)
        {
            MinimumStockAmount = minimumStockAmount;
        }
    }
}