using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO;
using StockEase.Domain.Interface.Repository;
using StockEase.Infrastructure.Persistence.Context;
using StockEase.Infrastructure.Persistence.Entry;

namespace StockEase.Infrastructure.Persistence.Repository
{
    public class StockMovementTypeRepository(AppDbContext context) : BaseRepository_3<StockMovementType, OutputStockMovementType, InputIdentifierStockMovementType, StockMovementTypeDTO, InternalPropertiesStockMovementTypeDTO, AuxiliaryPropertiesStockMovementTypeDTO>(context), IStockMovementTypeRepository { }
}