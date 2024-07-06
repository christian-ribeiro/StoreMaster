using Microsoft.AspNetCore.Mvc;
using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Arguments.Arguments.Base;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class UserController(IUserService service) : BaseController<IUserService, OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser>(service)
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<long>>> Create(InputCreateUser inputCreate)
        {
            throw new NotImplementedException();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<List<long>>>> Create(List<InputCreateUser> listInputCreate)
        {
            throw new NotImplementedException();
        }
    }
}