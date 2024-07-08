using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockMovement : BaseEntry<StockMovement>
    {
        public long ProductId { get; private set; }
        public long StockMovementTypeId { get; private set; }

        #region Virtual Properties
        #region Internal
        public virtual Product Product { get; private set; }
        public virtual StockMovementType StockMovementType { get; private set; }
        #endregion
        #endregion

        public StockMovement() { }

        public StockMovement(long productId, long stockMovementTypeId, StockMovementType stockMovementType)
        {
            ProductId = productId;
            StockMovementTypeId = stockMovementTypeId;
            StockMovementType = stockMovementType;
        }

#nullable disable
        public static StockMovementDTO GetDTO(StockMovement stockMovement)
        {
            return stockMovement == null ? default : new StockMovementDTO().Load(
                    new InternalPropertiesStockMovementDTO().SetInternalData(stockMovement.Id).SetInternalDataCreate(stockMovement.CreationDate, stockMovement.CreationUserId),
                    new ExternalPropertiesStockMovementDTO(stockMovement.ProductId, stockMovement.StockMovementTypeId),
                    new AuxiliaryPropertiesStockMovementDTO(stockMovement.Product, stockMovement.StockMovementType).SetInternalDataCreate(stockMovement.CreationUser)
                );
        }

        public static StockMovement GetEntry(StockMovementDTO dto)
        {
            return dto == null ? default : new StockMovement(dto.ExternalPropertiesDTO.ProductId, dto.ExternalPropertiesDTO.StockMovementTypeId, dto.AuxiliaryPropertiesDTO.StockMovementType)
                .SetInternalData(dto.InternalPropertiesDTO.Id)
                .SetInternalDataCreate(dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.CreationUserId, dto.AuxiliaryPropertiesDTO.CreationUser);
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