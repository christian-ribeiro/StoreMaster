using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputCreateStockMovement : BaseInputCreate<InputCreateStockMovement>
    {
        public decimal Quantity { get; private set; }
        public long ProductId { get; private set; }
        public long StockMovementTypeId { get; private set; }

        public InputCreateStockMovement(decimal quantity, long productId, long stockMovementTypeId)
        {
            Quantity = quantity;
            ProductId = productId;
            StockMovementTypeId = stockMovementTypeId;
        }
    }
}