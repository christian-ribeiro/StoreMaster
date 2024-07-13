using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service.Base;

namespace StockEase.Domain.Interface.Service
{
    public interface IStockMovementService : IBaseService_2<OutputStockMovement, InputIdentifierStockMovement, InputCreateStockMovement> { }
}