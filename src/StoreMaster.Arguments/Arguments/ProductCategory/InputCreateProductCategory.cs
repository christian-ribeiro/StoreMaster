using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputCreateProductCategory : BaseInputCreate<InputCreateProductCategory>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        public InputCreateProductCategory(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}