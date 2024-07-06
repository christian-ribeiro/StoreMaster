using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockMovement : BaseEntry<StockMovement>
    {
        public long StockMovementTypeId { get; private set; }

        #region Virtual Properties
        #region Internal
        public virtual StockMovementType StockMovementType { get; private set; }
        #endregion
        #endregion

        public StockMovement() { }

        public StockMovement(long stockMovementTypeId, StockMovementType stockMovementType)
        {
            StockMovementTypeId = stockMovementTypeId;
            StockMovementType = stockMovementType;
        }

#nullable disable
        public static StockMovementDTO GetDTO(StockMovement stockMovement)
        {
            return new StockMovementDTO().Load(
                    new InternalPropertiesStockMovementDTO(stockMovement.StockMovementTypeId).SetInternalData(stockMovement.Id, stockMovement.CreationDate, stockMovement.ChangeDate),
                    new ExternalPropertiesStockMovementDTO(),
                    new AuxiliaryPropertiesStockMovementDTO(stockMovement.StockMovementType)
                );
        }

        public static StockMovement GetEntry(StockMovementDTO dto)
        {
            return dto == null ? default : new StockMovement(dto.InternalPropertiesDTO.StockMovementTypeId, dto.AuxiliaryPropertiesDTO.StockMovementType).SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator StockMovementDTO(StockMovement stockmovement)
        {
            return GetDTO(stockmovement);
        }

        public static implicit operator StockMovement(StockMovementDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}