using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class StockMovementService(IStockMovementRepository repository) : BaseService_1<IStockMovementRepository, OutputStockMovement, InputIdentifierStockMovement, InputCreateStockMovement, StockMovementDTO, InternalPropertiesStockMovementDTO, ExternalPropertiesStockMovementDTO, AuxiliaryPropertiesStockMovementDTO>(repository), IStockMovementService
    {
        public override List<long> Create(List<InputCreateStockMovement> listInputCreate)
        {
            return base.Create(listInputCreate);
        }
    }
}