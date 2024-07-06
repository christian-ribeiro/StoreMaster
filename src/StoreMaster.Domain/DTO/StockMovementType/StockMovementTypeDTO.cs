using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class StockMovementTypeDTO : BaseDTO_2<OutputStockMovementType, InputIdentifierStockMovementType, StockMovementTypeDTO, InternalPropertiesStockMovementTypeDTO, AuxiliaryPropertiesStockMovementTypeDTO>
    {
#nullable disable
        public static StockMovementTypeDTO GetDTO(OutputStockMovementType output)
        {
            return output == null ? default : new StockMovementTypeDTO().Load(
                new InternalPropertiesStockMovementTypeDTO(output.Code, output.Description).SetInternalData(output.Id, output.CreationDate, output.ChangeDate),
                default,
                new AuxiliaryPropertiesStockMovementTypeDTO((from i in output.ListOutputStockMovement select (StockMovementDTO)i).ToList()));
        }

        public static OutputStockMovementType GetOutput(StockMovementTypeDTO dto)
        {
            return dto == null ? default : new OutputStockMovementType(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description, (from i in dto.AuxiliaryPropertiesDTO.ListStockMovement select (OutputStockMovement)i).ToList())
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator StockMovementTypeDTO(OutputStockMovementType output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputStockMovementType(StockMovementTypeDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}