using Microsoft.EntityFrameworkCore;
using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository;
using StockEase.Infrastructure.Persistence.Context;
using StockEase.Infrastructure.Persistence.Entry;

namespace StockEase.Infrastructure.Persistence.Repository
{
    public class StockMovementRepository(AppDbContext context) : BaseRepository_2<StockMovement, OutputStockMovement, InputIdentifierStockMovement, InputCreateStockMovement, StockMovementDTO, InternalPropertiesStockMovementDTO, ExternalPropertiesStockMovementDTO, AuxiliaryPropertiesStockMovementDTO>(context), IStockMovementRepository
    {
        public List<StockMovementDTO> GetListByListProductId(List<long> listProductId)
        {
            return FromEntryToDTO(_dbSet.Where(x => listProductId.Contains(x.ProductId)).AsNoTracking().ToList());
        }
    }
}