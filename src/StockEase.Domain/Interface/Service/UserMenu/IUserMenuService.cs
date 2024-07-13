using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service.Base;

namespace StockEase.Domain.Interface.Service
{
    public interface IUserMenuService : IBaseService_0<OutputUserMenu, InputIdentifierUserMenu, InputCreateUserMenu, InputUpdateUserMenu, InputIdentityUpdateUserMenu, InputReplaceUserMenu, InputIdentityDeleteUserMenu>
    {
        List<OutputCompleteUserMenu> GetCompleteMenu();
    }
}