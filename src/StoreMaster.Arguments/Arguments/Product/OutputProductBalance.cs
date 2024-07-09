namespace StoreMaster.Arguments.Arguments
{
    public class OutputProductBalance
    {
        public decimal Balance { get; private set; }
        public decimal MinimumStockAmount { get; private set; }
        public OutputProduct OutputProduct { get; private set; }

        public OutputProductBalance(decimal balance, decimal minimumStockAmount, OutputProduct outputProduct)
        {
            Balance = balance;
            OutputProduct = outputProduct;
            MinimumStockAmount = minimumStockAmount;
        }
    }
}