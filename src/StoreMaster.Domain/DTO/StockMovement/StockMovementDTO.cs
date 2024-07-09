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
                new InternalPropertiesStockMovementDTO(output.Sequence).SetInternalData(output.Id).SetInternalDataCreate(output.CreationDate, output.CreationUserId),
                new ExternalPropertiesStockMovementDTO(output.Quantity, output.ProductId, output.StockMovementTypeId),
                new AuxiliaryPropertiesStockMovementDTO(output.Product, output.StockMovementType).SetInternalDataCreate(output.CreationUser));
        }

        public static OutputStockMovement GetOutput(StockMovementDTO dto)
        {
            return dto == null ? default : new OutputStockMovement(dto.InternalPropertiesDTO.Sequence, dto.ExternalPropertiesDTO.Quantity, dto.ExternalPropertiesDTO.ProductId, dto.ExternalPropertiesDTO.StockMovementTypeId, dto.AuxiliaryPropertiesDTO.Product, dto.AuxiliaryPropertiesDTO.StockMovementType)
                .SetInternalData(dto.InternalPropertiesDTO.Id)
                .SetInternalDataCreate(dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.CreationUserId, dto.AuxiliaryPropertiesDTO.CreationUser);
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