using StoreMaster.Arguments;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class UserMenuService(IUserMenuRepository repository, IMenuRepository menuRepository) : BaseService_0<IUserMenuRepository, OutputUserMenu, InputIdentifierUserMenu, InputCreateUserMenu, InputUpdateUserMenu, InputIdentityUpdateUserMenu, InputReplaceUserMenu, InputIdentityDeleteUserMenu, UserMenuDTO, InternalPropertiesUserMenuDTO, ExternalPropertiesUserMenuDTO, AuxiliaryPropertiesUserMenuDTO>(repository), IUserMenuService
    {
        private readonly IMenuRepository _menuRepository = menuRepository;

        public override List<long> Create(List<InputCreateUserMenu> listInputCreateUserMenu)
        {
            long loggedUserId = SessionData.GetLoggedUser()?.Id ?? 0;

            List<UserMenuDTO> listOriginalUserMenuDTO = _repository.GetListByListIdentifier((from i in listInputCreateUserMenu select new InputIdentifierUserMenu(loggedUserId, i.MenuId)).ToList(), true);
            List<MenuDTO> listRelatedMenuDTO = _menuRepository.GetListByListId((from i in listInputCreateUserMenu select i.MenuId).ToList(), true);

            var listCreate = (from i in listInputCreateUserMenu
                              let relatedMenuDTO = (from j in listRelatedMenuDTO where j.InternalPropertiesDTO.Id == i.MenuId select j).FirstOrDefault()
                              let originalUserMenuDTO = (from j in listOriginalUserMenuDTO where j.ExternalPropertiesDTO.MenuId == i.MenuId select j).FirstOrDefault()
                              where relatedMenuDTO != null && originalUserMenuDTO == null
                              select new UserMenuDTO().Create(i)).ToList();

            return _repository.Create(listCreate);
        }

        public override List<long> Update(List<InputIdentityUpdateUserMenu> listInputIdentityUpdateUserMenu)
        {
            long loggedUserId = SessionData.GetLoggedUser()?.Id ?? 0;

            List<UserMenuDTO> listOriginalUserMenuDTO = _repository.GetListByListId((from i in listInputIdentityUpdateUserMenu select i.Id).ToList(), true);

            var listUpdate = (from i in listInputIdentityUpdateUserMenu
                              let originalUserMenuDTO = (from j in listOriginalUserMenuDTO where j.InternalPropertiesDTO.Id == i.Id select j).FirstOrDefault()
                              where originalUserMenuDTO != null
                              select new UserMenuDTO().Update(new ExternalPropertiesUserMenuDTO(i.InputUpdate.Position, i.InputUpdate.SecondPosition, i.InputUpdate.Favorite, i.InputUpdate.Visible, originalUserMenuDTO.ExternalPropertiesDTO.MenuId), originalUserMenuDTO.InternalPropertiesDTO)).ToList();

            return _repository.Update(listUpdate);
        }

        public override List<long> Replace(List<InputReplaceUserMenu> listInputReplace)
        {
            long loggedUserId = SessionData.GetLoggedUser()?.Id ?? 0;

            List<MenuDTO> listMenuDTO = _menuRepository.GetAll(true);
            List<UserMenuDTO> listOriginalUserMenuDTO = _repository.GetListByListIdentifier((from i in listMenuDTO select new InputIdentifierUserMenu(loggedUserId, i.InternalPropertiesDTO.Id)).ToList(), true);

            _repository.Delete(listOriginalUserMenuDTO);

            var listCreate = (from i in listInputReplace
                              let relatedMenuDTO = (from j in listMenuDTO where j.InternalPropertiesDTO.Id == i.MenuId select j).FirstOrDefault()
                              where relatedMenuDTO != null
                              select new UserMenuDTO().Replace(i)).ToList();

            return _repository.Create(listCreate);
        }

        public override bool Delete(List<InputIdentityDeleteUserMenu> listInputIdentityDeleteUserMenu)
        {
            List<UserMenuDTO> listOriginalUserMenuDTO = _repository.GetListByListId((from i in listInputIdentityDeleteUserMenu select i.Id).ToList(), true);
            return _repository.Delete(listOriginalUserMenuDTO);
        }
    }
}