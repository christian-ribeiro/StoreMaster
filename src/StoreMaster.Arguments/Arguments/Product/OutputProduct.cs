using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputProduct : BaseOutput<OutputProduct>
    {
        public long ProductCategoryId { get; set; }
        public OutputProductCategory? ProductCategory { get; set; }

        public OutputProduct() { }

        public OutputProduct(long productCategoryId, OutputProductCategory? productCategory)
        {
            ProductCategoryId = productCategoryId;
            ProductCategory = productCategory;
        }
    }
}