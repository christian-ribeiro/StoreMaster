using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputIdentifierStockMovement : BaseInputIdentifier<InputIdentifierStockMovement>
    {
        public int Sequence { get; private set; }
        public long ProductId { get; private set; }

        public InputIdentifierStockMovement() { }

        public InputIdentifierStockMovement(int sequence, long productId)
        {
            Sequence = sequence;
            ProductId = productId;
        }
    }
}