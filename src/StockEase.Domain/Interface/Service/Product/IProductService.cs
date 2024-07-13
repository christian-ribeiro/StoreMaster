using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service.Base;

namespace StockEase.Domain.Interface.Service
{
    public interface IProductService : IBaseService_1<OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct>
    {
        List<OutputProductBalance> GetListProductBalance(long productCategoryId);
    }
}