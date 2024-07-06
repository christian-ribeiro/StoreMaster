using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class UserService(IUserRepository repository) : BaseService<IUserRepository, OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser, UserDTO, InternalPropertiesUserDTO, ExternalPropertiesUserDTO, AuxiliaryPropertiesUserDTO>(repository), IUserService
    {
        public override List<long> Create(List<InputCreateUser> listInputCreate)
        {
            return base.Create(listInputCreate);
        }

        public override List<long> Update(List<InputIdentityUpdateUser> listInputIdentityUpdate)
        {
            return base.Update(listInputIdentityUpdate);
        }

        public override bool Delete(List<InputIdentityDeleteUser> listInputIdentityDelete)
        {
            return base.Delete(listInputIdentityDelete);
        }

        #region Custom
        public long GetOrCreateOAuthUser(string oAuthProvider, string oAuthUserId, string email, string name)
        {
            UserDTO user = _repository.GetByProvider(oAuthProvider, oAuthUserId);

            if (user == null)
            {
                user = new UserDTO().Create(new InputCreateUser(oAuthProvider, oAuthUserId, email, name));
                _repository.Create(user);
            }

            return user.InternalPropertiesDTO.Id;
        }
        #endregion
    }
}