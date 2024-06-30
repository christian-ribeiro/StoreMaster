using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class ProductCategoryService(IProductCategoryRepository repository) : BaseService<IProductCategoryRepository, OutputProductCategory, InputIdentifierProductCategory, InputCreateProductCategory, InputUpdateProductCategory, InputIdentityUpdateProductCategory, InputIdentityDeleteProductCategory, ProductCategoryDTO, InternalPropertiesProductCategoryDTO, ExternalPropertiesProductCategoryDTO, AuxiliaryPropertiesProductCategoryDTO>(repository), IProductCategoryService
    {
        public override List<long> Create(List<InputCreateProductCategory> listInputCreate)
        {
            return base.Create(listInputCreate);
        }

        public override List<long> Update(List<InputIdentityUpdateProductCategory> listInputIdentityUpdate)
        {
            return base.Update(listInputIdentityUpdate);
        }

        public override bool Delete(List<InputIdentityDeleteProductCategory> listInputIdentityDelete)
        {
            return base.Delete(listInputIdentityDelete);
        }
    }
}