using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputUpdateProductCategory : BaseInputUpdate<InputUpdateProductCategory>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        public InputUpdateProductCategory(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}