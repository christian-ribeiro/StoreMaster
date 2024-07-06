using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class ProductService(IProductRepository repository, IProductCategoryRepository productCategoryRepository) : BaseService<IProductRepository, OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct, ProductDTO, InternalPropertiesProductDTO, ExternalPropertiesProductDTO, AuxiliaryPropertiesProductDTO>(repository), IProductService
    {
        private readonly IProductCategoryRepository _productCategoryRepository = productCategoryRepository;

        public override List<long> Create(List<InputCreateProduct> listInputCreateProduct)
        {
            var listRelatedProductCategoryDTO = _productCategoryRepository.GetListByListId((from i in listInputCreateProduct select i.ProductCategoryId).ToList());

            var listCreate = (from i in listInputCreateProduct
                              let relatedProductCategory = (from j in listRelatedProductCategoryDTO where j.InternalPropertiesDTO.Id == i.ProductCategoryId select j).FirstOrDefault()
                              let dto = new ProductDTO().Create(i)
                              where relatedProductCategory != null
                              select dto).ToList();

            return _repository.Create(listCreate);
        }

        public override List<long> Update(List<InputIdentityUpdateProduct> listInputIdentityUpdateProduct)
        {
            var listOriginalProductDTO = _repository.GetListByListId((from i in listInputIdentityUpdateProduct select i.Id).ToList());
            var listRelatedProductCategoryDTO = _productCategoryRepository.GetListByListId((from i in listInputIdentityUpdateProduct select i.InputUpdate.ProductCategoryId).ToList());

            var listUpdate = (from i in listInputIdentityUpdateProduct
                              let originalProduct = (from j in listOriginalProductDTO where j.InternalPropertiesDTO.Id == i.Id select j).FirstOrDefault()
                              let relatedProductCategory = (from j in listRelatedProductCategoryDTO where j.InternalPropertiesDTO.Id == i.InputUpdate.ProductCategoryId select j).FirstOrDefault()
                              where originalProduct != null && relatedProductCategory != null
                              let dto = new ProductDTO().Update(i.InputUpdate, originalProduct.InternalPropertiesDTO)
                              where relatedProductCategory != null
                              select dto).ToList();

            return _repository.Update(listUpdate);
        }

        public override bool Delete(List<InputIdentityDeleteProduct> listInputIdentityDeleteProduct)
        {
            List<ProductDTO> listOriginalProductDTO = _repository.GetListByListId((from i in listInputIdentityDeleteProduct select i.Id).ToList());
            return _repository.Delete(listOriginalProductDTO);
        }
    }
}