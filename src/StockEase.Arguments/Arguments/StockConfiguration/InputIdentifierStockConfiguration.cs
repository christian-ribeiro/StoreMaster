using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentifierStockConfiguration : BaseInputIdentifier<InputIdentifierStockConfiguration>
    {
        public long ProductId { get; private set; }

        public InputIdentifierStockConfiguration() { }

        public InputIdentifierStockConfiguration(long productId)
        {
            ProductId = productId;
        }
    }
}