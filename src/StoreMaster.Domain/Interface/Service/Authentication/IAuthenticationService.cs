using StoreMaster.Arguments;
using StoreMaster.Arguments.Arguments;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IAuthenticationService
    {
        OutputAuthentication Login(InputAuthentication inputAuthentication);
        OutputAuthentication RefreshToken(InputRefreshTokenAuthentication inputRefreshTokenAuthentication);
        long Register(InputRegisterAuthentication inputRegisterAuthentication);
    }
}