using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputProductCategory : BaseOutput<OutputProductCategory>
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public OutputProductCategory() { }

        public OutputProductCategory(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}