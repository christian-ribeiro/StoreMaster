using StoreMaster.Arguments;
using StoreMaster.Arguments.Arguments;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IAuthenticationService
    {
        OutputAuthenticationUser SignIn(InputAuthenticationUser inputAuthenticationUser);
        long Register(InputRegisterAuthenticationUser inputRegisterAuthenticationUser);
    }
}