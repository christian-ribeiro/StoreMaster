using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers.StockMovementType
{
    public class StockMovementTypeController(IStockMovementTypeService service) : BaseController_2<IStockMovementTypeService, OutputStockMovementType, InputIdentifierStockMovementType>(service) { }
}