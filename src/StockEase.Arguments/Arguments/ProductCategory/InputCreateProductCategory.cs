using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
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