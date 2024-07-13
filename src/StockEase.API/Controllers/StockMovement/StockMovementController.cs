using StockEase.API.Controllers.Base;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers
{
    public class StockMovementController(IStockMovementService service, IUserService userService) : BaseController_2<IStockMovementService, OutputStockMovement, InputIdentifierStockMovement, InputCreateStockMovement>(service, userService) { }
}