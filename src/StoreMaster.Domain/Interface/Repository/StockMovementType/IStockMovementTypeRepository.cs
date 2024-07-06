using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository.Base;

namespace StoreMaster.Domain.Interface.Repository
{
    public interface IStockMovementTypeRepository : IBaseRepository_2<OutputStockMovementType, InputIdentifierStockMovementType, StockMovementTypeDTO, InternalPropertiesStockMovementTypeDTO, AuxiliaryPropertiesStockMovementTypeDTO> { }
}