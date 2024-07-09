namespace StoreMaster.Arguments.Arguments
{
    public class OutputProductStock
    {
        public decimal Quantity { get; private set; }
        public decimal MinimumStockAmount { get; private set; }
        public OutputProduct OutputProduct { get; private set; }

        public OutputProductStock(decimal quantity, decimal minimumStockAmount, OutputProduct outputProduct)
        {
            Quantity = quantity;
            OutputProduct = outputProduct;
            MinimumStockAmount = minimumStockAmount;
        }
    }
}