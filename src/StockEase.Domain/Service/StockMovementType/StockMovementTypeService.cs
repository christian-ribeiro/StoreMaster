using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository;
using StockEase.Domain.Interface.Service;
using StockEase.Domain.Service.Base;

namespace StockEase.Domain.Service
{
    public class StockMovementTypeService(IStockMovementTypeRepository repository) : BaseService_3<IStockMovementTypeRepository, OutputStockMovementType, InputIdentifierStockMovementType, StockMovementTypeDTO, InternalPropertiesStockMovementTypeDTO, AuxiliaryPropertiesStockMovementTypeDTO>(repository), IStockMovementTypeService { }
}