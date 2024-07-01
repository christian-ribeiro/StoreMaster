using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputUpdateProduct : BaseInputUpdate<InputUpdateProduct>
    {
        public long ProductCategoryId { get; private set; }

        public InputUpdateProduct(long productCategoryId)
        {
            ProductCategoryId = productCategoryId;
        }
    }
}