using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class UserDTO : BaseDTO<OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser, UserDTO, InternalPropertiesUserDTO, ExternalPropertiesUserDTO, AuxiliaryPropertiesUserDTO>
    {
#nullable disable
        public static UserDTO GetDTO(OutputUser output)
        {
            return output == null ? default : new UserDTO().Load(
                new InternalPropertiesUserDTO(output.OAuthProvider, output.OAuthUserId).SetInternalData(output.Id, output.CreationDate, output.ChangeDate),
                new ExternalPropertiesUserDTO(output.Email, output.Name),
                new AuxiliaryPropertiesUserDTO());
        }

        public static OutputUser GetOutput(UserDTO dto)
        {
            return dto == null ? default : new OutputUser(dto.ExternalPropertiesDTO.Email, dto.ExternalPropertiesDTO.Name, dto.InternalPropertiesDTO.OAuthProvider, dto.InternalPropertiesDTO.OAuthUserId)
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator UserDTO(OutputUser output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputUser(UserDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}
