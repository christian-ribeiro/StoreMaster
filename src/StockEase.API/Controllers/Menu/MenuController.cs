using StockEase.API.Controllers.Base;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers
{
    public class MenuController(IMenuService service, IUserService userService) : BaseController_3<IMenuService, OutputMenu, InputIdentifierMenu>(service, userService) { }
}