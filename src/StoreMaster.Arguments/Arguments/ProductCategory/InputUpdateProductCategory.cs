using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputUpdateProductCategory : BaseInputUpdate<InputUpdateProductCategory>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        public InputUpdateProductCategory() { }

        public InputUpdateProductCategory(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}