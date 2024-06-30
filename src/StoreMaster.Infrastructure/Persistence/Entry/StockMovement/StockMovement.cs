using StoreMaster.Arguments.Enums;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockMovement : BaseEntry<StockMovement>
    {
        public EnumStockMovementType StockMovementType { get; private set; }

        public StockMovement(EnumStockMovementType stockMovementType)
        {
            StockMovementType = stockMovementType;
        }
    }
}