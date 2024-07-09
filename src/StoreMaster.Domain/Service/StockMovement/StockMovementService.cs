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
            List<StockMovementDTO> listStockMovementDTO = _repository.GetListByListProductId((from i in listInputCreateStockMovement select i.ProductId).ToList());
            List<ProductDTO> listRelatedProductDTO = _productRepository.GetListByListId((from i in listInputCreateStockMovement select i.ProductId).ToList());
            List<StockMovementTypeDTO> listRelatedStockMovementTypeDTO = _stockMovementTypeRepository.GetListByListId((from i in listInputCreateStockMovement select i.StockMovementTypeId).ToList());

            var maxSequenceByProduct = listStockMovementDTO
                .GroupBy(x => x.ExternalPropertiesDTO.ProductId)
                .ToDictionary(g => g.Key, g => g.Max(x => x.InternalPropertiesDTO.Sequence));

            var currentSequenceByProduct = new Dictionary<long, int>();

            var listCreate = (from i in listInputCreateStockMovement
                              let relatedProduct = (from j in listRelatedProductDTO where j.InternalPropertiesDTO.Id == i.ProductId select j).FirstOrDefault()
                              let relatedStockMovementType = (from j in listRelatedStockMovementTypeDTO where j.InternalPropertiesDTO.Id == i.StockMovementTypeId select j).FirstOrDefault()
                              where relatedProduct != null && relatedStockMovementType != null
                              let sequence = GetNextSequence(i.ProductId, maxSequenceByProduct, currentSequenceByProduct)
                              select new StockMovementDTO().Create(i, new InternalPropertiesStockMovementDTO(sequence))).ToList();

            return _repository.Create(listCreate);
        }

        private static int GetNextSequence(long productId, Dictionary<long, int> maxSequenceByProduct, Dictionary<long, int> currentSequenceByProduct)
        {
            if (!currentSequenceByProduct.ContainsKey(productId))
                currentSequenceByProduct[productId] = maxSequenceByProduct.ContainsKey(productId) ? maxSequenceByProduct[productId] + 1 : 1;
            else
                currentSequenceByProduct[productId]++;

            return currentSequenceByProduct[productId];
        }
    }
}