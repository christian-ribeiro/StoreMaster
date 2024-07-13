using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository;
using StockEase.Infrastructure.Persistence.Context;
using StockEase.Infrastructure.Persistence.Entry;

namespace StockEase.Infrastructure.Persistence.Repository
{
    public class UserStatusRepository(AppDbContext context) : BaseRepository_3<UserStatus, OutputUserStatus, InputIdentifierUserStatus, UserStatusDTO, InternalPropertiesUserStatusDTO, AuxiliaryPropertiesUserStatusDTO>(context), IUserStatusRepository { }
}