using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Infrastructure.Persistence.Context;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Repository
{
    public class StockConfigurationRepository(AppDbContext context) : BaseRepository_1<StockConfiguration, OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration, StockConfigurationDTO, InternalPropertiesStockConfigurationDTO, ExternalPropertiesStockConfigurationDTO, AuxiliaryPropertiesStockConfigurationDTO>(context), IStockConfigurationRepository { }
}