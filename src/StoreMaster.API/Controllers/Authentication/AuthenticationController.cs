using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreMaster.Arguments;
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

        [HttpPost("Register")]
        public ActionResult<long> Register([FromHeader] Guid publicKey, [FromHeader] Guid secretKey, [FromBody] InputRegisterAuthenticationUser inputRegisterAuthenticationUser)
        {
            try
            {
                if (publicKey == new Guid("14e1428c-7c01-4eb6-8054-20611c114229") && secretKey == new Guid("a395b1a2-31bc-4d78-9f07-63bdcd37a54b"))
                    return Ok(_authenticationService.Register(inputRegisterAuthenticationUser));
                else
                    return Unauthorized();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}