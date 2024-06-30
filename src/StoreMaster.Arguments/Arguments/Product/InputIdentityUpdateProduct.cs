using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputIdentityUpdateProduct : BaseInputIdentityUpdate<InputUpdateProduct>
    {
        public InputIdentityUpdateProduct(long id, InputUpdateProduct inputUpdate) : base(id, inputUpdate) { }
    }
}