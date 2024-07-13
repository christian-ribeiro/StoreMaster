using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentityUpdateStockConfiguration : BaseInputIdentityUpdate<InputUpdateStockConfiguration>
    {
        public InputIdentityUpdateStockConfiguration(long id, InputUpdateStockConfiguration inputUpdate) : base(id, inputUpdate) { }
    }
}