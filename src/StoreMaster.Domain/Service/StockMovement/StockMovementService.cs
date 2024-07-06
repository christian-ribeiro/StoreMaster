using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class StockMovementService(IStockMovementRepository repository, IProductRepository productRepository, IStockMovementTypeRepository stockMovementTypeRepository) : BaseService_1<IStockMovementRepository, OutputStockMovement, InputIdentifierStockMovement, InputCreateStockMovement, StockMovementDTO, InternalPropertiesStockMovementDTO, ExternalPropertiesStockMovementDTO, AuxiliaryPropertiesStockMovementDTO>(repository), IStockMovementService
    {
        private readonly IProductRepository _productRepository = productRepository;
        private readonly IStockMovementTypeRepository _stockMovementTypeRepository = stockMovementTypeRepository;
        public override List<long> Create(List<InputCreateStockMovement> listInputCreateStockMovement)
        {
            List<ProductDTO> listRelatedProductDTO = _productRepository.GetListByListId((from i in listInputCreateStockMovement select i.ProductId).ToList());
            List<StockMovementTypeDTO> listRelatedStockMovementTypeDTO = _stockMovementTypeRepository.GetListByListId((from i in listInputCreateStockMovement select i.StockMovementTypeId).ToList());

            var listCreate = (from i in listInputCreateStockMovement
                              let relatedProduct = (from j in listRelatedProductDTO where j.InternalPropertiesDTO.Id == i.ProductId select j).FirstOrDefault()
                              let relatedStockMovementType = (from j in listRelatedStockMovementTypeDTO where j.InternalPropertiesDTO.Id == i.StockMovementTypeId select j).FirstOrDefault()
                              where relatedProduct != null && relatedStockMovementType != null
                              select new StockMovementDTO().Create(i)).ToList();

            return _repository.Create(listCreate);
        }
    }
}