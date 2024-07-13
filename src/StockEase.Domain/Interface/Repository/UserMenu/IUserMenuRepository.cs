using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository.Base;

namespace StockEase.Domain.Interface.Repository
{
    public interface IUserMenuRepository : IBaseRepository_0<OutputUserMenu, InputIdentifierUserMenu, InputCreateUserMenu, InputUpdateUserMenu, InputIdentityUpdateUserMenu, InputReplaceUserMenu, InputIdentityDeleteUserMenu, UserMenuDTO, InternalPropertiesUserMenuDTO, ExternalPropertiesUserMenuDTO, AuxiliaryPropertiesUserMenuDTO> { }
}