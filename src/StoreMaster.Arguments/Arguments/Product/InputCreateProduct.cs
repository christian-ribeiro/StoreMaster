using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputCreateProduct : BaseInputCreate<InputCreateProduct>
    {
        public long ProductCategoryId { get; private set; }

        public InputCreateProduct(long productCategoryId)
        {
            ProductCategoryId = productCategoryId;
        }
    }
}