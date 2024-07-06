using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputStockConfiguration : BaseOutput<OutputStockConfiguration>
    {
        public decimal MinimumStockAmount { get; set; }
        public long ProductId { get; set; }

        #region Virtual Properties
        #region Internal
        public OutputProduct Product { get; set; }
        #endregion
        #endregion
        public OutputStockConfiguration() { }

        public OutputStockConfiguration(decimal minimumStockAmount, long productId, OutputProduct product)
        {
            MinimumStockAmount = minimumStockAmount;
            ProductId = productId;
            Product = product;
        }
    }
}