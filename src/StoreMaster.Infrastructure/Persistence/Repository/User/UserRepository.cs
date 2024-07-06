using Microsoft.EntityFrameworkCore;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Infrastructure.Persistence.Context;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Repository
{
    public class UserRepository(AppDbContext context) : BaseRepository<User, OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser, UserDTO, InternalPropertiesUserDTO, ExternalPropertiesUserDTO, AuxiliaryPropertiesUserDTO>(context), IUserRepository
    {

        public UserDTO? GetByProvider(string oAuthProvider, string oAuthUserId)
        {
            return _dbSet.Where(x => x.OAuthProvider == oAuthProvider && x.OAuthUserId == oAuthUserId).AsNoTracking().FirstOrDefault();
        }
    }
}