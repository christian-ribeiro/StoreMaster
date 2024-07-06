using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service.Base;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IUserService : IBaseService<OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser>
    {
        long GetOrCreateOAuthUser(string oAuthProvider, string oAuthUserId, string email, string name);
    }
}