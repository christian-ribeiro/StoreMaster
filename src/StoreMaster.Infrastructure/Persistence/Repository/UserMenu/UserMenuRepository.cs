using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Infrastructure.Persistence.Context;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Repository
{
    public class UserMenuRepository(AppDbContext context) : BaseRepository_0<UserMenu, OutputUserMenu, InputIdentifierUserMenu, InputCreateUserMenu, InputUpdateUserMenu, InputIdentityUpdateUserMenu, InputReplaceUserMenu, InputIdentityDeleteUserMenu, UserMenuDTO, InternalPropertiesUserMenuDTO, ExternalPropertiesUserMenuDTO, AuxiliaryPropertiesUserMenuDTO>(context), IUserMenuRepository { }
}