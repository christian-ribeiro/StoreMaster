using StoreMaster.Arguments.Enums;
using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class StockMovement : BaseEntry<StockMovement>
    {
        public EnumStockMovementType StockMovementType { get; private set; }

        [JsonConstructor]
        public StockMovement(EnumStockMovementType stockMovementType)
        {
            StockMovementType = stockMovementType;
        }

#nullable disable
        public static StockMovementDTO GetDTO(StockMovement stockmovement)
        {
            return new StockMovementDTO().Load(
                    new InternalPropertiesStockMovementDTO(stockmovement.StockMovementType).SetInternalData(stockmovement.Id, stockmovement.CreationDate, stockmovement.ChangeDate),
                    new ExternalPropertiesStockMovementDTO(),
                    new AuxiliaryPropertiesStockMovementDTO()
                );
        }

        public static StockMovement GetEntry(StockMovementDTO dto)
        {
            return dto == null ? default : new StockMovement(dto.InternalPropertiesDTO.StockMovementType).SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
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