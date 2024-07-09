using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockMovement : BaseEntry<StockMovement>
    {
        public int Sequence { get; private set; }
        public decimal Quantity { get; private set; }
        public long ProductId { get; private set; }
        public long StockMovementTypeId { get; private set; }

        #region NotMapped
        [NotMapped]
        public override DateTime? ChangeDate => base.ChangeDate;
        [NotMapped]
        public override long? ChangeUserId => base.ChangeUserId;
        [NotMapped]
        public override User? ChangeUser => base.ChangeUser;
        #endregion


        #region Virtual Properties
        #region Internal
        public virtual Product Product { get; private set; }
        public virtual StockMovementType StockMovementType { get; private set; }
        #endregion
        #endregion

        public StockMovement() { }

        public StockMovement(int sequence, decimal quantity, long productId, long stockMovementTypeId, Product product, StockMovementType stockMovementType)
        {
            Sequence = sequence;
            Quantity = quantity;
            ProductId = productId;
            StockMovementTypeId = stockMovementTypeId;
            Product = product;
            StockMovementType = stockMovementType;
        }

#nullable disable
        public static StockMovementDTO GetDTO(StockMovement stockMovement)
        {
            return stockMovement == null ? default : new StockMovementDTO().Load(
                    new InternalPropertiesStockMovementDTO(stockMovement.Sequence).SetInternalData(stockMovement.Id).SetInternalDataCreate(stockMovement.CreationDate, stockMovement.CreationUserId),
                    new ExternalPropertiesStockMovementDTO(stockMovement.Quantity, stockMovement.ProductId, stockMovement.StockMovementTypeId),
                    new AuxiliaryPropertiesStockMovementDTO(stockMovement.Product, stockMovement.StockMovementType).SetInternalDataCreate(stockMovement.CreationUser)
                );
        }

        public static StockMovement GetEntry(StockMovementDTO dto)
        {
            return dto == null ? default : new StockMovement(dto.InternalPropertiesDTO.Sequence, dto.ExternalPropertiesDTO.Quantity, dto.ExternalPropertiesDTO.ProductId, dto.ExternalPropertiesDTO.StockMovementTypeId, dto.AuxiliaryPropertiesDTO.Product, dto.AuxiliaryPropertiesDTO.StockMovementType)
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