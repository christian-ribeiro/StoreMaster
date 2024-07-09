using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class StockConfigurationService(IStockConfigurationRepository repository, IProductRepository productRepository) : BaseService_1<IStockConfigurationRepository, OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration, StockConfigurationDTO, InternalPropertiesStockConfigurationDTO, ExternalPropertiesStockConfigurationDTO, AuxiliaryPropertiesStockConfigurationDTO>(repository), IStockConfigurationService
    {
        private readonly IProductRepository _productRepository = productRepository;

        public override List<long> Create(List<InputCreateStockConfiguration> listInputCreateStockConfiguration)
        {
            List<ProductDTO> listRelatedProductDTO = _productRepository.GetListByListId((from i in listInputCreateStockConfiguration select i.ProductId).ToList());

            var listCreate = (from i in listInputCreateStockConfiguration
                              let relatedProduct = (from j in listRelatedProductDTO where j.InternalPropertiesDTO.Id == i.ProductId select j).FirstOrDefault()
                              where relatedProduct != null
                              select new StockConfigurationDTO().Create(i)).ToList();

            return _repository.Create(listCreate);
        }

        public override List<long> Update(List<InputIdentityUpdateStockConfiguration> listInputIdentityUpdateStockConfiguration)
        {
            List<StockConfigurationDTO> listOriginalStockConfigurationDTO = _repository.GetListByListId((from i in listInputIdentityUpdateStockConfiguration select i.Id).ToList());

            var listUpdate = (from i in listInputIdentityUpdateStockConfiguration
                              let originalStockConfiguration = (from j in listOriginalStockConfigurationDTO where j.InternalPropertiesDTO.Id == i.Id select j).FirstOrDefault()
                              where originalStockConfiguration != null
                              select new StockConfigurationDTO().Update(new ExternalPropertiesStockConfigurationDTO(i.InputUpdate.MinimumStockAmount, originalStockConfiguration.ExternalPropertiesDTO.ProductId), originalStockConfiguration.InternalPropertiesDTO)).ToList();

            return _repository.Update(listUpdate);
        }

        public override bool Delete(List<InputIdentityDeleteStockConfiguration> listInputIdentityDeleteStockConfiguration)
        {
            var listOriginalStockConfigurationDTO = _repository.GetListByListId((from i in listInputIdentityDeleteStockConfiguration select i.Id).ToList());
            return _repository.Delete(listOriginalStockConfigurationDTO);
        }
    }
}