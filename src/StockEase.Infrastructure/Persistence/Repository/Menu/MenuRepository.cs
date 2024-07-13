using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository;
using StockEase.Infrastructure.Persistence.Context;
using StockEase.Infrastructure.Persistence.Entry;

namespace StockEase.Infrastructure.Persistence.Repository
{
    public class MenuRepository(AppDbContext context) : BaseRepository_3<Menu, OutputMenu, InputIdentifierMenu, MenuDTO, InternalPropertiesMenuDTO, AuxiliaryPropertiesMenuDTO>(context), IMenuRepository { }
}