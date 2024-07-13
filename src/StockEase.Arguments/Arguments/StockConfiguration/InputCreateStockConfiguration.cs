using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputCreateStockConfiguration : BaseInputCreate<InputCreateStockConfiguration>
    {
        public decimal MinimumStockAmount { get; private set; }
        public long ProductId { get; private set; }

        public InputCreateStockConfiguration(decimal minimumStockAmount, long productId)
        {
            MinimumStockAmount = minimumStockAmount;
            ProductId = productId;
        }
    }
}