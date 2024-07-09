using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class MenuController(IMenuService service, IUserService userService) : BaseController_2<IMenuService, OutputMenu, InputIdentifierMenu>(service, userService) { }
}