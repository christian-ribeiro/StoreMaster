using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository.Base;

namespace StockEase.Domain.Interface.Repository
{
    public interface IStockMovementTypeRepository : IBaseRepository_3<OutputStockMovementType, InputIdentifierStockMovementType, StockMovementTypeDTO, InternalPropertiesStockMovementTypeDTO, AuxiliaryPropertiesStockMovementTypeDTO> { }
}