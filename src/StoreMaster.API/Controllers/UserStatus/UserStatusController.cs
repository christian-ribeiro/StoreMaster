using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class UserStatusController(IUserStatusService service, IUserService userService) : BaseController_3<IUserStatusService, OutputUserStatus, InputIdentifierUserStatus>(service, userService) { }
}