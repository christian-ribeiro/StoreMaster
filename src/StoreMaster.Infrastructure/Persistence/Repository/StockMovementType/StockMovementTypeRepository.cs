using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Interface.Repository;
using StoreMaster.Infrastructure.Persistence.Context;
using StoreMaster.Infrastructure.Persistence.Entry;

namespace StoreMaster.Infrastructure.Persistence.Repository
{
    public class StockMovementTypeRepository(AppDbContext context) : BaseRepository_3<StockMovementType, OutputStockMovementType, InputIdentifierStockMovementType, StockMovementTypeDTO, InternalPropertiesStockMovementTypeDTO, AuxiliaryPropertiesStockMovementTypeDTO>(context), IStockMovementTypeRepository { }
}