using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository.Base;

namespace StoreMaster.Domain.Interface.Repository
{
    public interface IStockConfigurationRepository : IBaseRepository_1<OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration, StockConfigurationDTO, InternalPropertiesStockConfigurationDTO, ExternalPropertiesStockConfigurationDTO, AuxiliaryPropertiesStockConfigurationDTO> { }
}