using StoreMaster.Arguments.Arguments.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputStockMovement : BaseOutput<OutputStockMovement>
    {
        #region Ignore
        [JsonIgnore]
        public override DateTime? ChangeDate { get => base.ChangeDate; set => base.ChangeDate = value; }
        #endregion

        public long StockMovementTypeId { get; set; }

        #region Virtual Properties
        #region Internal
        public OutputStockMovementType StockMovementType { get; set; }
        #endregion
        #endregion

        public OutputStockMovement() { }

        public OutputStockMovement(long stockMovementTypeId, OutputStockMovementType stockMovementType)
        {
            StockMovementTypeId = stockMovementTypeId;
            StockMovementType = stockMovementType;
        }
    }
}