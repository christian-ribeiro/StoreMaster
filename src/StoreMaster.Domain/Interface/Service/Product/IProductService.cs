using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service.Base;

namespace StoreMaster.Domain.Interface.Service
{
    public interface IProductService : IBaseService<OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct>
    {
        List<OutputProductBalance> GetListProductBalance(long productCategoryId);
    }
}