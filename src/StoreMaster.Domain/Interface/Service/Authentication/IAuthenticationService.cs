using StoreMaster.Arguments.Arguments;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IAuthenticationService
    {
        OutputAuthenticationUser SignIn(InputAuthenticationUser inputAuthenticationUser);
    }
}