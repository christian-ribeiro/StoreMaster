using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class StockConfigurationService(IStockConfigurationRepository repository) : BaseService<IStockConfigurationRepository, OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration, StockConfigurationDTO, InternalPropertiesStockConfigurationDTO, ExternalPropertiesStockConfigurationDTO, AuxiliaryPropertiesStockConfigurationDTO>(repository), IStockConfigurationService
    {
        public override List<long> Create(List<InputCreateStockConfiguration> listInputCreate)
        {
            return base.Create(listInputCreate);
        }

        public override List<long> Update(List<InputIdentityUpdateStockConfiguration> listInputIdentityUpdate)
        {
            return base.Update(listInputIdentityUpdate);
        }

        public override bool Delete(List<InputIdentityDeleteStockConfiguration> listInputIdentityDelete)
        {
            return base.Delete(listInputIdentityDelete);
        }
    }
}