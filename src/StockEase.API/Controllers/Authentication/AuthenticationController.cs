using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StockEase.Arguments;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers.Authentication
{
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService = authenticationService;

        [HttpPost("Login")]
        public ActionResult<OutputAuthentication> Login([FromBody] InputAuthentication inputAuthentication)
        {
            try
            {
                return Ok(_authenticationService.Login(inputAuthentication));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("RefreshToken")]
        public ActionResult<OutputAuthentication> RefreshToken([FromBody] InputRefreshTokenAuthentication inputRefreshTokenAuthentication)
        {
            try
            {
                return Ok(_authenticationService.RefreshToken(inputRefreshTokenAuthentication));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("Register")]
        public ActionResult<long> Register([FromHeader] Guid publicKey, [FromHeader] Guid secretKey, [FromBody] InputRegisterAuthentication inputRegisterAuthentication)
        {
            try
            {
                if (publicKey == new Guid("14e1428c-7c01-4eb6-8054-20611c114229") && secretKey == new Guid("a395b1a2-31bc-4d78-9f07-63bdcd37a54b"))
                    return Ok(_authenticationService.Register(inputRegisterAuthentication));
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