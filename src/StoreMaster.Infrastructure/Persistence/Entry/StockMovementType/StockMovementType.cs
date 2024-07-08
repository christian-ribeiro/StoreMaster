using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockMovementType : BaseEntry<StockMovementType>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        #region NotMapped
        [NotMapped]
        public override DateTime CreationDate => base.CreationDate;
        [NotMapped]
        public override DateTime? ChangeDate => base.ChangeDate;
        [NotMapped]
        public override long CreationUserId => base.CreationUserId;
        [NotMapped]
        public override long? ChangeUserId => base.ChangeUserId;
        [NotMapped]
        public override User? CreationUser => base.CreationUser;
        [NotMapped]
        public override User? ChangeUser => base.ChangeUser;
        #endregion

        #region Virtual Properties
        #region External
        public virtual List<StockMovement> ListStockMovement { get; private set; }
        #endregion
        #endregion

        public StockMovementType() { }

        public StockMovementType(string code, string description)
        {
            Code = code;
            Description = description;
        }

#nullable disable
        public static StockMovementTypeDTO GetDTO(StockMovementType stockMovementType)
        {
            return stockMovementType == null ? default : new StockMovementTypeDTO().Load(
                    new InternalPropertiesStockMovementTypeDTO(stockMovementType.Code, stockMovementType.Description)
                    .SetInternalData(stockMovementType.Id),
                    default,
                    new AuxiliaryPropertiesStockMovementTypeDTO()
                );
        }

        public static StockMovementType GetEntry(StockMovementTypeDTO dto)
        {
            return dto == null ? default : new StockMovementType(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description)
                .SetInternalData(dto.InternalPropertiesDTO.Id);
        }

        public static implicit operator StockMovementTypeDTO(StockMovementType stockmovementtype)
        {
            return GetDTO(stockmovementtype);
        }

        public static implicit operator StockMovementType(StockMovementTypeDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}