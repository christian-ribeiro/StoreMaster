using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputProduct : BaseOutput<OutputProduct>
    {
        public string Description { get; set; }
        public long ProductCategoryId { get; set; }

        #region VirtualProperties
        #region Internal
        public OutputProductCategory ProductCategory { get; set; }
        #endregion
        #region External
        public OutputStockConfiguration StockConfiguration { get; set; }
        public List<OutputStockMovement> ListStockMovement { get; set; }
        #endregion
        #endregion

        public OutputProduct() { }

        public OutputProduct(string description, long productCategoryId, OutputProductCategory productCategory, OutputStockConfiguration stockConfiguration, List<OutputStockMovement> listStockMovement)
        {
            Description = description;
            ProductCategoryId = productCategoryId;
            ProductCategory = productCategory;
            StockConfiguration = stockConfiguration;
            ListStockMovement = listStockMovement;
        }
    }
}