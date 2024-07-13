using StockEase.API.Controllers.Base;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers.StockConfiguration
{
    public class StockConfigurationController(IStockConfigurationService service, IUserService userService) : BaseController_1<IStockConfigurationService, OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration>(service, userService) { }
}