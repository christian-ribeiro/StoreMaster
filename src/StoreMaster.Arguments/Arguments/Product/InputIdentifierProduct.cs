using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
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