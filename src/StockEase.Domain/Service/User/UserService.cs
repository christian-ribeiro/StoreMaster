using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Extensions;
using StockEase.Domain.Interface.Repository;
using StockEase.Domain.Interface.Service;
using StockEase.Domain.Service.Base;

namespace StockEase.Domain.Service
{
    public class UserService(IUserRepository repository, ILanguageRepository languageRepository, IUserStatusRepository userStatusRepository) : BaseService_1<IUserRepository, OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser, UserDTO, InternalPropertiesUserDTO, ExternalPropertiesUserDTO, AuxiliaryPropertiesUserDTO>(repository), IUserService
    {
        private readonly ILanguageRepository _languageRepository = languageRepository;
        private readonly IUserStatusRepository _userStatusRepository = userStatusRepository;

        public override List<long> Create(List<InputCreateUser> listInputCreateUser)
        {
            List<LanguageDTO> listRelatedLanguageDTO = _languageRepository.GetListByListId((from i in listInputCreateUser select i.LanguageId).ToList());
            List<UserStatusDTO> listRelatedUserStatusDTO = _userStatusRepository.GetListByListId((from i in listInputCreateUser select i.UserStatusId).ToList());

            var listCreate = (from i in listInputCreateUser
                              let relatedLanguageDTO = (from j in listRelatedLanguageDTO where j.InternalPropertiesDTO.Id == i.LanguageId select j).FirstOrDefault()
                              let relatedUserStatusDTO = (from j in listRelatedUserStatusDTO where j.InternalPropertiesDTO.Id == i.UserStatusId select j).FirstOrDefault()
                              let dto = new UserDTO().Create(new InputCreateUser(i.Code, i.Name, i.Password.HashPassword(), i.ConfirmPassword.HashPassword(), i.Email, i.LanguageId, i.UserStatusId))
                              where relatedLanguageDTO != null && relatedUserStatusDTO != null && i.Password == i.ConfirmPassword
                              select dto).ToList();

            return _repository.Create(listCreate);
        }

        public override List<long> Update(List<InputIdentityUpdateUser> listInputIdentityUpdateUser)
        {
            List<UserDTO> listOriginalUserDTO = _repository.GetListByListId((from i in listInputIdentityUpdateUser select i.Id).ToList());
            List<LanguageDTO> listRelatedLanguageDTO = _languageRepository.GetListByListId((from i in listInputIdentityUpdateUser select i.InputUpdate.LanguageId).ToList());
            List<UserStatusDTO> listRelatedUserStatusDTO = _userStatusRepository.GetListByListId((from i in listInputIdentityUpdateUser select i.InputUpdate.UserStatusId).ToList());

            var listUpdate = (from i in listInputIdentityUpdateUser
                              let originalUserDTO = (from j in listOriginalUserDTO where j.InternalPropertiesDTO.Id == i.Id select j).FirstOrDefault()
                              let relatedLanguageDTO = (from j in listRelatedLanguageDTO where j.InternalPropertiesDTO.Id == i.InputUpdate.LanguageId select j).FirstOrDefault()
                              let relatedUserStatusDTO = (from j in listRelatedUserStatusDTO where j.InternalPropertiesDTO.Id == i.InputUpdate.UserStatusId select j).FirstOrDefault()
                              let dto = new UserDTO().Update(new InputUpdateUser(i.InputUpdate.Code, i.InputUpdate.Name, i.InputUpdate.Email, i.InputUpdate.LanguageId, i.InputUpdate.UserStatusId), originalUserDTO.InternalPropertiesDTO)
                              where originalUserDTO != null && relatedLanguageDTO != null && relatedUserStatusDTO != null
                              select dto).ToList();

            return _repository.Update(listUpdate);
        }

        public override bool Delete(List<InputIdentityDeleteUser> listInputIdentityDeleteUser)
        {
            List<UserDTO> listOriginalUserDTO = _repository.GetListByListId((from i in listInputIdentityDeleteUser select i.Id).ToList());
            return _repository.Delete(listOriginalUserDTO);
        }
    }
}