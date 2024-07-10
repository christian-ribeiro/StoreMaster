using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service.Base;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IUserMenuService : IBaseService_0<OutputUserMenu, InputIdentifierUserMenu, InputCreateUserMenu, InputUpdateUserMenu, InputIdentityUpdateUserMenu, InputReplaceUserMenu, InputIdentityDeleteUserMenu>
    {
        List<OutputCompleteUserMenu> GetCompleteMenu();
    }
}