using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputUpdateStockConfiguration : BaseInputUpdate<InputUpdateStockConfiguration>
    {
        public decimal MinimumStockAmount { get; set; }

        public InputUpdateStockConfiguration(decimal minimumStockAmount)
        {
            MinimumStockAmount = minimumStockAmount;
        }
    }
}