﻿using StoreMaster.Infrastructure.Persistence.Entry.Base;
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
    }
}