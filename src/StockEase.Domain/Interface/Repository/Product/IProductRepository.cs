using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository.Base;

namespace StockEase.Domain.Interface.Repository
{
    public interface IProductRepository : IBaseRepository_1<OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct, ProductDTO, InternalPropertiesProductDTO, ExternalPropertiesProductDTO, AuxiliaryPropertiesProductDTO>
    {
        List<ProductDTO> GetListByProductCategoryId(long productCategoryId);
    }
}