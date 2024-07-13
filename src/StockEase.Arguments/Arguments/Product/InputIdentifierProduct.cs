using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentifierProduct : BaseInputIdentifier<InputIdentifierProduct>
    {
        public string Description { get; private set; }

        public InputIdentifierProduct() { }

        public InputIdentifierProduct(string description)
        {
            Description = description;
        }
    }
}