using StockEase.Arguments.Arguments.Base;
using System.Text.Json.Serialization;

namespace StockEase.Arguments.Arguments
{
    public class OutputStockMovement : BaseOutput<OutputStockMovement>
    {
        #region Ignore
        [JsonIgnore]
        public override DateTime? ChangeDate { get => base.ChangeDate; set => base.ChangeDate = value; }
        [JsonIgnore]
        public override long? ChangeUserId { get => base.ChangeUserId; set => base.ChangeUserId = value; }
        [JsonIgnore]
        public override OutputUser ChangeUser { get => base.ChangeUser; set => base.ChangeUser = value; }
        #endregion

        public int Sequence { get; set; }
        public decimal Quantity { get; set; }
        public long ProductId { get; set; }
        public long StockMovementTypeId { get; set; }

        #region Virtual Properties
        #region Internal
        public OutputProduct Product { get; set; }
        public OutputStockMovementType StockMovementType { get; set; }
        #endregion
        #endregion

        public OutputStockMovement() { }

        public OutputStockMovement(int sequence, decimal quantity, long productId, long stockMovementTypeId, OutputProduct product, OutputStockMovementType stockMovementType)
        {
            Sequence = sequence;
            Quantity = quantity;
            ProductId = productId;
            StockMovementTypeId = stockMovementTypeId;
            StockMovementType = stockMovementType;
            Product = product;
        }
    }
}