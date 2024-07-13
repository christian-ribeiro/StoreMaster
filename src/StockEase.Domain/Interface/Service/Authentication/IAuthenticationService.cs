using StockEase.Arguments;
using StockEase.Arguments.Arguments;

namespace StockEase.Domain.Interface.Service
{
    public interface IAuthenticationService
    {
        OutputAuthentication Login(InputAuthentication inputAuthentication);
        OutputAuthentication RefreshToken(InputRefreshTokenAuthentication inputRefreshTokenAuthentication);
        long Register(InputRegisterAuthentication inputRegisterAuthentication);
    }
}