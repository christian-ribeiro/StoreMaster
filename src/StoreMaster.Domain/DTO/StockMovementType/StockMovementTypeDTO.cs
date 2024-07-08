using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;
using StoreMaster.Domain.Extensions;

namespace StoreMaster.Domain.DTO
{
    public class StockMovementTypeDTO : BaseDTO_2<OutputStockMovementType, InputIdentifierStockMovementType, StockMovementTypeDTO, InternalPropertiesStockMovementTypeDTO, AuxiliaryPropertiesStockMovementTypeDTO>
    {
#nullable disable
        public static StockMovementTypeDTO GetDTO(OutputStockMovementType output)
        {
            return output == null ? default : new StockMovementTypeDTO().Load(
                new InternalPropertiesStockMovementTypeDTO(output.Code, output.Description).SetInternalData(output.Id, output.CreationDate, output.ChangeDate, output.CreationUserId, default),
                default,
                new AuxiliaryPropertiesStockMovementTypeDTO().SetInternalData(output.CreationUser, default));
        }

        public static OutputStockMovementType GetOutput(StockMovementTypeDTO dto)
        {
            return dto == null ? default : new OutputStockMovementType(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description)
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate, dto.InternalPropertiesDTO.CreationUserId, default, dto.AuxiliaryPropertiesDTO.CreationUser, default);
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