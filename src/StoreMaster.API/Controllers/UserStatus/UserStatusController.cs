using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class UserStatusController(IUserStatusService service) : BaseController_2<IUserStatusService, OutputUserStatus, InputIdentifierUserStatus>(service) { }
}