using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentityUpdateProductCategory : BaseInputIdentityUpdate<InputUpdateProductCategory>
    {
        public InputIdentityUpdateProductCategory(long id, InputUpdateProductCategory inputUpdate) : base(id, inputUpdate) { }
    }
}