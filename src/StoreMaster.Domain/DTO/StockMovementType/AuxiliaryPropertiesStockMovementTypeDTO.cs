using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class AuxiliaryPropertiesStockMovementTypeDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesStockMovementTypeDTO>
    {
        public List<StockMovementDTO> ListStockMovement { get; private set; }

        public AuxiliaryPropertiesStockMovementTypeDTO() { }

        public AuxiliaryPropertiesStockMovementTypeDTO(List<StockMovementDTO> listStockMovement)
        {
            ListStockMovement = listStockMovement;
        }
    }
}