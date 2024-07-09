using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
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