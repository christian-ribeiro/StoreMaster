using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputIdentityUpdateStockConfiguration : BaseInputIdentityUpdate<InputUpdateStockConfiguration>
    {
        public InputIdentityUpdateStockConfiguration(long id, InputUpdateStockConfiguration inputUpdate) : base(id, inputUpdate) { }
    }
}