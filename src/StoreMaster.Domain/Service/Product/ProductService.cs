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

        public override List<long> Create(List<InputCreateProduct> listInputCreate)
        {
            var listRelatedProductCategory = _productCategoryRepository.GetListByListId((from i in listInputCreate select i.ProductCategoryId).ToList());
            var listCreate = (from i in listInputCreate
                              let relatedProductCategory = (from j in listRelatedProductCategory where j.InternalPropertiesDTO.Id == i.ProductCategoryId select j).FirstOrDefault()
                              let dto = new ProductDTO().Create(i)
                              where relatedProductCategory != null
                              select dto).ToList();

            return _repository.Create(listCreate);
        }

        public override List<long> Update(List<InputIdentityUpdateProduct> listInputIdentityUpdate)
        {
            return base.Update(listInputIdentityUpdate);
        }

        public override bool Delete(List<InputIdentityDeleteProduct> listInputIdentityDelete)
        {
            return base.Delete(listInputIdentityDelete);
        }
    }
}