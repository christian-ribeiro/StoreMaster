using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers.StockMovementType
{
    public class StockMovementTypeController(IStockMovementTypeService service, IUserService userService) : BaseController_3<IStockMovementTypeService, OutputStockMovementType, InputIdentifierStockMovementType>(service, userService) { }
}