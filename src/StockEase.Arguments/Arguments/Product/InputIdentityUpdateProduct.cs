using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentityUpdateProduct : BaseInputIdentityUpdate<InputUpdateProduct>
    {
        public InputIdentityUpdateProduct(long id, InputUpdateProduct inputUpdate) : base(id, inputUpdate) { }
    }
}