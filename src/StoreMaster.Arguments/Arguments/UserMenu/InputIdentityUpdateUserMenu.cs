using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputIdentityUpdateUserMenu : BaseInputIdentityUpdate<InputUpdateUserMenu>
    {
        public InputIdentityUpdateUserMenu(long id, InputUpdateUserMenu inputUpdate) : base(id, inputUpdate) { }
    }
}