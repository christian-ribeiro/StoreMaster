using StoreMaster.Arguments.Arguments;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class ProductCategory : BaseEntry<ProductCategory>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        #region Virtual Properties
        #region External
        public virtual List<Product> ListProduct { get; private set; }
        #endregion
        #endregion
        public ProductCategory() { }

        [JsonConstructor]
        public ProductCategory(string code, string description, List<Product> listProduct)
        {
            Code = code;
            Description = description;
            ListProduct = listProduct;
        }

#nullable disable
        public static implicit operator OutputProductCategory(ProductCategory productCategory)
        {
            return productCategory == null ? default : new OutputProductCategory(productCategory.Code, productCategory.Description, default);
        }

        public static implicit operator ProductCategory(OutputProductCategory output)
        {
            return output == null ? default : new ProductCategory(output.Code, output.Description, default).SetInternalData(output.Id, output.CreationDate, output.ChangeDate);
        }
#nullable enable
    }
}