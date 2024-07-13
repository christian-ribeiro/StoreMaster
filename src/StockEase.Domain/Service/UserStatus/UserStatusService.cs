using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository;
using StockEase.Domain.Interface.Service;
using StockEase.Domain.Service.Base;

namespace StockEase.Domain.Service
{
    public class UserStatusService(IUserStatusRepository repository) : BaseService_3<IUserStatusRepository, OutputUserStatus, InputIdentifierUserStatus, UserStatusDTO, InternalPropertiesUserStatusDTO, AuxiliaryPropertiesUserStatusDTO>(repository), IUserStatusService { }
}