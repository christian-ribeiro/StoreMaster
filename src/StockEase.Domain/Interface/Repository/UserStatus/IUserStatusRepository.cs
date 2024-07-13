using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository.Base;

namespace StockEase.Domain.Interface.Repository
{
    public interface IUserStatusRepository : IBaseRepository_3<OutputUserStatus, InputIdentifierUserStatus, UserStatusDTO, InternalPropertiesUserStatusDTO, AuxiliaryPropertiesUserStatusDTO> { }
}