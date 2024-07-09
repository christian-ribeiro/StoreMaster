using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class UserMenuDTO : BaseDTO_0<OutputUserMenu, InputIdentifierUserMenu, InputCreateUserMenu, InputUpdateUserMenu, InputIdentityUpdateUserMenu, InputReplaceUserMenu, InputIdentityDeleteUserMenu, UserMenuDTO, InternalPropertiesUserMenuDTO, ExternalPropertiesUserMenuDTO, AuxiliaryPropertiesUserMenuDTO>
    {
#nullable disable
        public static UserMenuDTO GetDTO(OutputUserMenu output)
        {
            return output == null ? default : new UserMenuDTO().Load(
                new InternalPropertiesUserMenuDTO().SetInternalData(output.Id, output.CreationDate, output.ChangeDate, output.CreationUserId, output.ChangeUserId),
                new ExternalPropertiesUserMenuDTO(output.Position, output.SecondPosition, output.Favorite, output.Visible, output.MenuId),
                new AuxiliaryPropertiesUserMenuDTO(output.Menu).SetInternalData(output.CreationUser, output.ChangeUser));
        }

        public static OutputUserMenu GetOutput(UserMenuDTO dto)
        {
            return dto == null ? default : new OutputUserMenu(dto.ExternalPropertiesDTO.Position, dto.ExternalPropertiesDTO.SecondPosition, dto.ExternalPropertiesDTO.Favorite, dto.ExternalPropertiesDTO.Visible, dto.ExternalPropertiesDTO.MenuId, dto.AuxiliaryPropertiesDTO.Menu)
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate, dto.InternalPropertiesDTO.CreationUserId, dto.InternalPropertiesDTO.ChangeUserId, dto.AuxiliaryPropertiesDTO.CreationUser, dto.AuxiliaryPropertiesDTO.ChangeUser);
        }

        public static implicit operator UserMenuDTO(OutputUserMenu output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputUserMenu(UserMenuDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}