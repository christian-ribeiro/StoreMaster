using StockEase.API.Controllers.Base;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers
{
    public class UserController(IUserService service, IUserService userService) : BaseController_1<IUserService, OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser>(service, userService) { }
}