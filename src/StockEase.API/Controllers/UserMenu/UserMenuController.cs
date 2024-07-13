using Microsoft.AspNetCore.Mvc;
using StockEase.API.Controllers.Base;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers
{
    public class UserMenuController(IUserMenuService service, IUserService userService) : BaseController_0<IUserMenuService, OutputUserMenu, InputIdentifierUserMenu, InputCreateUserMenu, InputUpdateUserMenu, InputIdentityUpdateUserMenu, InputReplaceUserMenu, InputIdentityDeleteUserMenu>(service, userService)
    {
        [HttpGet("GetCompleteMenu")]
        public async Task<ActionResult<List<OutputCompleteUserMenu>>> GetCompleteMenu()
        {
            try
            {
                return await ResponseAsync(_service.GetCompleteMenu());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}