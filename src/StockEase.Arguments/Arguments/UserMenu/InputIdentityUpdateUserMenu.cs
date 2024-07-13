using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentityUpdateUserMenu : BaseInputIdentityUpdate<InputUpdateUserMenu>
    {
        public InputIdentityUpdateUserMenu(long id, InputUpdateUserMenu inputUpdate) : base(id, inputUpdate) { }
    }
}