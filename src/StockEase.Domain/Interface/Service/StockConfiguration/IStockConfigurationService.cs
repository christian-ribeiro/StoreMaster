using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service.Base;

namespace StockEase.Domain.Interface.Service
{
    public interface IStockConfigurationService : IBaseService_1<OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration> { }
}