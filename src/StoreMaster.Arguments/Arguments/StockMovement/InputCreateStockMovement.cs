using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputCreateStockMovement : BaseInputCreate<InputCreateStockMovement>
    {
        public long ProductId { get; private set; }
        public long StockMovementTypeId { get; private set; }

        public InputCreateStockMovement(long productId, long stockMovementTypeId)
        {
            ProductId = productId;
            StockMovementTypeId = stockMovementTypeId;
        }
    }
}