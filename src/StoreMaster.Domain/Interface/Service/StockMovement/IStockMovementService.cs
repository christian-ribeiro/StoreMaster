using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service.Base;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IStockMovementService : IBaseService_2<OutputStockMovement, InputIdentifierStockMovement, InputCreateStockMovement> { }
}