using Microsoft.EntityFrameworkCore;
using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository;
using StockEase.Infrastructure.Persistence.Context;
using StockEase.Infrastructure.Persistence.Entry;

namespace StockEase.Infrastructure.Persistence.Repository
{
    public class ProductRepository(AppDbContext context) : BaseRepository_1<Product, OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct, ProductDTO, InternalPropertiesProductDTO, ExternalPropertiesProductDTO, AuxiliaryPropertiesProductDTO>(context), IProductRepository
    {
        public List<ProductDTO> GetListByProductCategoryId(long productCategoryId)
        {
            return FromEntryToDTO(_dbSet.Where(x => x.ProductCategoryId == productCategoryId).Include(x => x.ProductCategory).AsNoTracking().ToList());
        }
    }
}