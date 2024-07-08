using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class StockMovementController(IStockMovementService service, IUserService userService) : BaseController_1<IStockMovementService, OutputStockMovement, InputIdentifierStockMovement, InputCreateStockMovement>(service, userService) { }
}