using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputUpdateProduct : BaseInputUpdate<InputUpdateProduct>
    {
        public string Description { get; private set; }
        public long ProductCategoryId { get; private set; }

        public InputUpdateProduct(string description, long productCategoryId)
        {
            Description = description;
            ProductCategoryId = productCategoryId;
        }
    }
}