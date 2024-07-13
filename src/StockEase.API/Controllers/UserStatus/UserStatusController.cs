using StockEase.API.Controllers.Base;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers
{
    public class UserStatusController(IUserStatusService service, IUserService userService) : BaseController_3<IUserStatusService, OutputUserStatus, InputIdentifierUserStatus>(service, userService) { }
}