using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository;
using StockEase.Infrastructure.Persistence.Context;
using StockEase.Infrastructure.Persistence.Entry;

namespace StockEase.Infrastructure.Persistence.Repository
{
    public class StockConfigurationRepository(AppDbContext context) : BaseRepository_1<StockConfiguration, OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration, StockConfigurationDTO, InternalPropertiesStockConfigurationDTO, ExternalPropertiesStockConfigurationDTO, AuxiliaryPropertiesStockConfigurationDTO>(context), IStockConfigurationRepository { }
}