using StoreMaster.Arguments.Arguments.Base;
using StoreMaster.Arguments.Enums;
using System.Text.Json.Serialization;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputStockMovement : BaseOutput<OutputStockMovement>
    {
        [JsonIgnore]
        public override DateTime? ChangeDate { get => base.ChangeDate; set => base.ChangeDate = value; }
        public EnumStockMovementType StockMovementType { get; set; }

        public OutputStockMovement() { }

        public OutputStockMovement(EnumStockMovementType stockMovementType)
        {
            StockMovementType = stockMovementType;
        }
    }
}