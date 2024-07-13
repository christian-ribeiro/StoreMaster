using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository.Base;

namespace StockEase.Domain.Interface.Repository
{
    public interface IMenuRepository : IBaseRepository_3<OutputMenu, InputIdentifierMenu, MenuDTO, InternalPropertiesMenuDTO, AuxiliaryPropertiesMenuDTO> { }
}