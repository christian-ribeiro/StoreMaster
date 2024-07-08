using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class UserService(IUserRepository repository) : BaseService<IUserRepository, OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser, UserDTO, InternalPropertiesUserDTO, ExternalPropertiesUserDTO, AuxiliaryPropertiesUserDTO>(repository), IUserService
    {
    }
}