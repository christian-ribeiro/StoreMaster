using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers.Authentication
{
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService = authenticationService;

        [HttpPost("SignIn")]
        public ActionResult<OutputAuthenticationUser> SignIn([FromBody] InputAuthenticationUser inputAuthenticationUser)
        {
            try
            {
                return Ok(_authenticationService.SignIn(inputAuthenticationUser));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}