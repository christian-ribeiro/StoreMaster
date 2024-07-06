using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class StockConfigurationDTO : BaseDTO<OutputStockConfiguration, InputIdentifierStockConfiguration, InputCreateStockConfiguration, InputUpdateStockConfiguration, InputIdentityUpdateStockConfiguration, InputIdentityDeleteStockConfiguration, StockConfigurationDTO, InternalPropertiesStockConfigurationDTO, ExternalPropertiesStockConfigurationDTO, AuxiliaryPropertiesStockConfigurationDTO>
    {
#nullable disable
        public static StockConfigurationDTO GetDTO(OutputStockConfiguration output)
        {
            return output == null ? default : new StockConfigurationDTO().Load(
                new InternalPropertiesStockConfigurationDTO().SetInternalData(output.Id, output.CreationDate, output.ChangeDate),
                new ExternalPropertiesStockConfigurationDTO(output.MinimumStockAmount, output.ProductId),
                new AuxiliaryPropertiesStockConfigurationDTO());
        }

        public static OutputStockConfiguration GetOutput(StockConfigurationDTO dto)
        {
            return dto == null ? default : new OutputStockConfiguration(dto.ExternalPropertiesDTO.MinimumStockAmount, dto.ExternalPropertiesDTO.ProductId, dto.AuxiliaryPropertiesDTO.Product).SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator StockConfigurationDTO(OutputStockConfiguration output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputStockConfiguration(StockConfigurationDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}