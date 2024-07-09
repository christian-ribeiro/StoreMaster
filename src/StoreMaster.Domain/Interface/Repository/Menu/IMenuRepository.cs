using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository.Base;

namespace StoreMaster.Domain.Interface.Repository
{
    public interface IMenuRepository : IBaseRepository_3<OutputMenu, InputIdentifierMenu, MenuDTO, InternalPropertiesMenuDTO, AuxiliaryPropertiesMenuDTO> { }
}