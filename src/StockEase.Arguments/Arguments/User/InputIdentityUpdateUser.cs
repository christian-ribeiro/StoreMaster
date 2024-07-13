using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentityUpdateUser : BaseInputIdentityUpdate<InputUpdateUser>
    {
        public InputIdentityUpdateUser(long id, InputUpdateUser inputUpdate) : base(id, inputUpdate) { }
    }
}