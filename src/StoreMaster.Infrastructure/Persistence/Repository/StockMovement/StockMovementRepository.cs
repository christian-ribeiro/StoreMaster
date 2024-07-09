using Microsoft.EntityFrameworkCore;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Infrastructure.Persistence.Context;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Repository
{
    public class StockMovementRepository(AppDbContext context) : BaseRepository_1<StockMovement, OutputStockMovement, InputIdentifierStockMovement, InputCreateStockMovement, StockMovementDTO, InternalPropertiesStockMovementDTO, ExternalPropertiesStockMovementDTO, AuxiliaryPropertiesStockMovementDTO>(context), IStockMovementRepository
    {
        public List<StockMovementDTO> GetListByListProductId(List<long> listProductId)
        {
            return FromEntryToDTO(_dbSet.Where(x => listProductId.Contains(x.ProductId)).AsNoTracking().ToList());
        }
    }
}