using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
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