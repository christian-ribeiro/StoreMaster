using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class ProductService(IProductRepository repository) : BaseService<IProductRepository, OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct, ProductDTO, InternalPropertiesProductDTO, ExternalPropertiesProductDTO, AuxiliaryPropertiesProductDTO>(repository), IProductService
    {
        public override List<long> Create(List<InputCreateProduct> listInputCreate)
        {
            return base.Create(listInputCreate);
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