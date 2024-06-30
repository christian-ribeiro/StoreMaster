using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service.Base;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IStockConfigurationService : IBaseService<OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration> { }
}