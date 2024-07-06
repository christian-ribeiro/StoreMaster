using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class AuxiliaryPropertiesProductDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesProductDTO>
    {
        #region Virtual Properties
        #region Internal
        public ProductCategoryDTO ProductCategory { get; private set; }
        #endregion
        #region External
        public StockConfigurationDTO StockConfiguration { get; private set; }
        public List<StockMovementDTO> ListStockMovement { get; private set; }
        #endregion
        #endregion

        public AuxiliaryPropertiesProductDTO() { }

        public AuxiliaryPropertiesProductDTO(ProductCategoryDTO productCategory, StockConfigurationDTO stockConfiguration, List<StockMovementDTO> listStockMovement)
        {
            ProductCategory = productCategory;
            StockConfiguration = stockConfiguration;
            ListStockMovement = listStockMovement;
        }
    }
}