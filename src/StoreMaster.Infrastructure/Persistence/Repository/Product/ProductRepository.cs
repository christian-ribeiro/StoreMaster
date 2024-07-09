using Microsoft.EntityFrameworkCore;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Infrastructure.Persistence.Context;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Repository
{
    public class ProductRepository(AppDbContext context) : BaseRepository_1<Product, OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct, ProductDTO, InternalPropertiesProductDTO, ExternalPropertiesProductDTO, AuxiliaryPropertiesProductDTO>(context), IProductRepository
    {
        public List<ProductDTO> GetListByProductCategoryId(long productCategoryId)
        {
            return FromEntryToDTO(_dbSet.Where(x => x.ProductCategoryId == productCategoryId).Include(x => x.ProductCategory).AsNoTracking().ToList());
        }
    }
}