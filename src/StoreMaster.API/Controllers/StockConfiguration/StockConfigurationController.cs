using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers.StockConfiguration
{
    public class StockConfigurationController(IStockConfigurationService service, IUserService userService) : BaseController_1<IStockConfigurationService, OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration>(service, userService) { }
}