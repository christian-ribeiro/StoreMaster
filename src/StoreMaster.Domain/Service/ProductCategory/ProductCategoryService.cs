using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Domain.Interface.Service;
using StoreMaster.Domain.Service.Base;

namespace StoreMaster.Domain.Service
{
    public class ProductCategoryService(IProductCategoryRepository repository) : BaseService<IProductCategoryRepository, OutputProductCategory, InputIdentifierProductCategory, InputCreateProductCategory, InputUpdateProductCategory, InputIdentityUpdateProductCategory, InputIdentityDeleteProductCategory, ProductCategoryDTO, InternalPropertiesProductCategoryDTO, ExternalPropertiesProductCategoryDTO, AuxiliaryPropertiesProductCategoryDTO>(repository), IProductCategoryService
    {
        public override List<long> Create(List<InputCreateProductCategory> listInputCreateProductCategory)
        {
            var listCreate = (from i in listInputCreateProductCategory select new ProductCategoryDTO().Create(i)).ToList();
            return _repository.Create(listCreate);
        }

        public override List<long> Update(List<InputIdentityUpdateProductCategory> listInputIdentityUpdateProductCategory)
        {
            var listOriginalProductCategory = _repository.GetListByListId((from i in listInputIdentityUpdateProductCategory select i.Id).ToList());

            var listUpdate = (from i in listInputIdentityUpdateProductCategory
                              let originalProductCategory = (from j in listOriginalProductCategory where j.InternalPropertiesDTO.Id == i.Id select j).FirstOrDefault()
                              where originalProductCategory != null
                              select new ProductCategoryDTO().Update(i.InputUpdate, originalProductCategory.InternalPropertiesDTO)).ToList();

            return _repository.Update(listUpdate);
        }

        public override bool Delete(List<InputIdentityDeleteProductCategory> listInputIdentityDeleteProductCategory)
        {
            var listOriginalProductCategoryDTO = _repository.GetListByListId((from i in listInputIdentityDeleteProductCategory select i.Id).ToList());
            return _repository.Delete(listOriginalProductCategoryDTO);
        }
    }
}