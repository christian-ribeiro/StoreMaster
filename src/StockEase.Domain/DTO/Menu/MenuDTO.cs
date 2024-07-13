using StockEase.Arguments.Arguments;
using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class MenuDTO : BaseDTO_3<OutputMenu, InputIdentifierMenu, MenuDTO, InternalPropertiesMenuDTO, AuxiliaryPropertiesMenuDTO>
    {
#nullable disable
        public static MenuDTO GetDTO(OutputMenu output)
        {
            return output == null ? default : new MenuDTO().Load(
                new InternalPropertiesMenuDTO(output.Path, output.Label, output.Position, output.Visible, output.ToolTip, output.ParentId).SetInternalData(output.Id),
                default,
                new AuxiliaryPropertiesMenuDTO());
        }

        public static OutputMenu GetOutput(MenuDTO dto)
        {
            return dto == null ? default : new OutputMenu(dto.InternalPropertiesDTO.Path, dto.InternalPropertiesDTO.Label, dto.InternalPropertiesDTO.Position, dto.InternalPropertiesDTO.Visible, dto.InternalPropertiesDTO.ToolTip, dto.InternalPropertiesDTO.ParentId)
                .SetInternalData(dto.InternalPropertiesDTO.Id);
        }

        public static implicit operator MenuDTO(OutputMenu output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputMenu(MenuDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}