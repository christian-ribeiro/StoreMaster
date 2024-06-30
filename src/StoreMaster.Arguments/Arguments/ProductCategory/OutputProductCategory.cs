using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputProductCategory : BaseOutput<OutputProductCategory>
    {
        public string Code { get;  set; }
        public string Description { get;  set; }
        public List<OutputProduct> ListProduct { get; set; }

        public OutputProductCategory() { }

        public OutputProductCategory(string code, string description, List<OutputProduct> listProduct)
        {
            Code = code;
            Description = description;
            ListProduct = listProduct;
        }
    }
}