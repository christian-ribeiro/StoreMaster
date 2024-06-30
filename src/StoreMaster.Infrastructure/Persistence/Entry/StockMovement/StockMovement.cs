using StoreMaster.Arguments.Arguments;
using StoreMaster.Arguments.Enums;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockMovement : BaseEntry<StockMovement>
    {
        public EnumStockMovementType StockMovementType { get; private set; }

        [JsonConstructor]
        public StockMovement(EnumStockMovementType stockMovementType)
        {
            StockMovementType = stockMovementType;
        }

#nullable disable
        public static implicit operator OutputStockMovement(StockMovement stockmovement)
        {
            return stockmovement == null ? default : new OutputStockMovement(stockmovement.StockMovementType).SetInternalData(stockmovement.Id, stockmovement.CreationDate, stockmovement.ChangeDate);
        }

        public static implicit operator StockMovement(OutputStockMovement output)
        {
            return output == null ? default : new StockMovement(output.StockMovementType).SetInternalData(output.Id, output.CreationDate, output.ChangeDate);
        }
#nullable enable
    }
}