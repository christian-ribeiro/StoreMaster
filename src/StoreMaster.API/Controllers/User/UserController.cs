using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class UserController(IUserService service) : BaseController<IUserService, OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser>(service) { }
}