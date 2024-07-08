using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Arguments.Arguments.Base;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class UserController(IUserService service) : BaseController<IUserService, OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser>(service)
    {
        [AllowAnonymous]
        public override async Task<ActionResult<BaseResponseApi<long>>> Create(InputCreateUser inputCreate)
        {
            try
            {
                return await ResponseAsync(_service?.Create(inputCreate), 201);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}