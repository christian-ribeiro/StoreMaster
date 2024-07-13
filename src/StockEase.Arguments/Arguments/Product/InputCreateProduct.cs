using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputCreateProduct : BaseInputCreate<InputCreateProduct>
    {
        public string Description { get; private set; }
        public long ProductCategoryId { get; private set; }

        public InputCreateProduct(string description, long productCategoryId)
        {
            Description = description;
            ProductCategoryId = productCategoryId;
        }
    }
}