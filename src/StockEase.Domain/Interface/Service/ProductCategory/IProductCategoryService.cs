using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service.Base;

namespace StockEase.Domain.Interface.Service
{
    public interface IProductCategoryService : IBaseService_1<OutputProductCategory, InputIdentifierProductCategory, InputCreateProductCategory, InputUpdateProductCategory, InputIdentityUpdateProductCategory, InputIdentityDeleteProductCategory> { }
}