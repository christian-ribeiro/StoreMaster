using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository;
using StockEase.Domain.Interface.Service;
using StockEase.Domain.Service.Base;

namespace StockEase.Domain.Service
{
    public class MenuService(IMenuRepository repository) : BaseService_3<IMenuRepository, OutputMenu, InputIdentifierMenu, MenuDTO, InternalPropertiesMenuDTO, AuxiliaryPropertiesMenuDTO>(repository), IMenuService { }
}