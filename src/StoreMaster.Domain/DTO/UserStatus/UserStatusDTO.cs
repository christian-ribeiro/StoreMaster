using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;
using StoreMaster.Domain.Extensions;

namespace StoreMaster.Domain.DTO
{
    public class UserStatusDTO : BaseDTO_2<OutputUserStatus, InputIdentifierUserStatus, UserStatusDTO, InternalPropertiesUserStatusDTO, AuxiliaryPropertiesUserStatusDTO>
    {
#nullable disable
        public static UserStatusDTO GetDTO(OutputUserStatus output)
        {
            return output == null ? default : new UserStatusDTO().Load(
                new InternalPropertiesUserStatusDTO(output.Code, output.Description).SetInternalData(output.Id, output.CreationDate, output.ChangeDate),
                default,
                new AuxiliaryPropertiesUserStatusDTO(output.ListUser.ConvertAll<UserDTO>()));
        }

        public static OutputUserStatus GetOutput(UserStatusDTO dto)
        {
            return dto == null ? default : new OutputUserStatus(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description, dto.AuxiliaryPropertiesDTO.ListUser.ConvertAll<OutputUser>())
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator UserStatusDTO(OutputUserStatus output)
        {
            return GetDTO(output);
        }

        public static implicit operator OutputUserStatus(UserStatusDTO dto)
        {
            return GetOutput(dto);
        }
#nullable enable
    }
}