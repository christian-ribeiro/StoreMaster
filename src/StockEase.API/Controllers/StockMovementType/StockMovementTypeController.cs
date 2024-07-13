using StockEase.API.Controllers.Base;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers.StockMovementType
{
    public class StockMovementTypeController(IStockMovementTypeService service, IUserService userService) : BaseController_3<IStockMovementTypeService, OutputStockMovementType, InputIdentifierStockMovementType>(service, userService) { }
}