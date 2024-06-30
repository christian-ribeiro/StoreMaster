using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputIdentityUpdateProductCategory : BaseInputIdentityUpdate<InputUpdateProductCategory>
    {
        public InputIdentityUpdateProductCategory(long id, InputUpdateProductCategory inputUpdate) : base(id, inputUpdate) { }
    }
}