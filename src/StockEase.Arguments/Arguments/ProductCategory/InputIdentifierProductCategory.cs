using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentifierProductCategory : BaseInputIdentifier<InputIdentifierProductCategory>
    {
        public string Code { get; private set; }

        public InputIdentifierProductCategory() { }

        public InputIdentifierProductCategory(string code)
        {
            Code = code;
        }
    }
}