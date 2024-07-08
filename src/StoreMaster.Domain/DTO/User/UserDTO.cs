using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;
using StoreMaster.Domain.Extensions;

namespace StoreMaster.Domain.DTO
{
    public class UserDTO : BaseDTO<OutputUser, InputIdentifierUser, InputCreateUser, InputUpdateUser, InputIdentityUpdateUser, InputIdentityDeleteUser, UserDTO, InternalPropertiesUserDTO, ExternalPropertiesUserDTO, AuxiliaryPropertiesUserDTO>
    {
#nullable disable
        public static UserDTO GetDTO(OutputUser output)
        {
            return output == null ? default : new UserDTO().Load(
                new InternalPropertiesUserDTO().SetInternalData(output.Id, output.CreationDate, output.ChangeDate),
                new ExternalPropertiesUserDTO(output.Code, output.Name, output.Password, output.Email, output.LanguageId, output.UserStatusId),
                new AuxiliaryPropertiesUserDTO(output.Language, output.UserStatus));
        }

        public static OutputUser GetOutput(UserDTO dto)
        {
            return dto == null ? default : new OutputUser(dto.ExternalPropertiesDTO.Code, dto.ExternalPropertiesDTO.Name, dto.ExternalPropertiesDTO.Password, dto.ExternalPropertiesDTO.Email, dto.ExternalPropertiesDTO.LanguageId, dto.ExternalPropertiesDTO.UserStatusId, dto.AuxiliaryPropertiesDTO.Language, dto.AuxiliaryPropertiesDTO.UserStatus)
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