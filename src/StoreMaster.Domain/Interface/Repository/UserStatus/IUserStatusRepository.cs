using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository.Base;

namespace StoreMaster.Domain.Interface.Repository
{
    public interface IUserStatusRepository : IBaseRepository_2<OutputUserStatus, InputIdentifierUserStatus, UserStatusDTO, InternalPropertiesUserStatusDTO, AuxiliaryPropertiesUserStatusDTO> { }
}