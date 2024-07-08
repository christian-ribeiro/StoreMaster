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
        #endregion

        public OutputProduct() { }

        public OutputProduct(string description, long productCategoryId, OutputProductCategory productCategory)
        {
            Description = description;
            ProductCategoryId = productCategoryId;
            ProductCategory = productCategory;
        }
    }
}