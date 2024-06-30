using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class StockMovementDTO : BaseDTO_1<OutputStockMovement, InputIdentifierStockMovement, InputCreateStockMovement, StockMovementDTO, InternalPropertiesStockMovementDTO, ExternalPropertiesStockMovementDTO, AuxiliaryPropertiesStockMovementDTO>
    {
#nullable disable
        public static StockMovementDTO GetDTO(OutputStockMovement output)
        {
            return output == null ? default : new StockMovementDTO().Load(
                new InternalPropertiesStockMovementDTO(output.StockMovementType).SetInternalData(output.Id, output.CreationDate, output.ChangeDate),
                new ExternalPropertiesStockMovementDTO(),
                new AuxiliaryPropertiesStockMovementDTO());
        }

        public static OutputStockMovement GetOutput(StockMovementDTO dto)
        {
            return dto == null ? default : new OutputStockMovement(dto.InternalPropertiesDTO.StockMovementType).SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator StockMovementDTO(OutputStockMovement output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputStockMovement(StockMovementDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}