using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Extensions;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockMovementType : BaseEntry<StockMovementType>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        #region Virtual Properties
        #region External
        public virtual List<StockMovement> ListStockMovement { get; private set; }
        #endregion
        #endregion


        public StockMovementType() { }

        public StockMovementType(string code, string description, List<StockMovement> listStockMovement)
        {
            Code = code;
            Description = description;
            ListStockMovement = listStockMovement;
        }

#nullable disable
        public static StockMovementTypeDTO GetDTO(StockMovementType stockMovementType)
        {
            return stockMovementType == null ? default : new StockMovementTypeDTO().Load(
                    new InternalPropertiesStockMovementTypeDTO(stockMovementType.Code, stockMovementType.Description).SetInternalData(stockMovementType.Id, stockMovementType.CreationDate, stockMovementType.ChangeDate),
                    default,
                    new AuxiliaryPropertiesStockMovementTypeDTO(stockMovementType.ListStockMovement.ConvertAll<StockMovementDTO>())
                );
        }

        public static StockMovementType GetEntry(StockMovementTypeDTO dto)
        {
            return dto == null ? default : new StockMovementType(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description, dto.AuxiliaryPropertiesDTO.ListStockMovement.ConvertAll<StockMovement>())
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
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