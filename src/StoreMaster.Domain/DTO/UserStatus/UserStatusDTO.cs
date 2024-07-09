using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class UserStatusDTO : BaseDTO_3<OutputUserStatus, InputIdentifierUserStatus, UserStatusDTO, InternalPropertiesUserStatusDTO, AuxiliaryPropertiesUserStatusDTO>
    {
#nullable disable
        public static UserStatusDTO GetDTO(OutputUserStatus output)
        {
            return output == null ? default : new UserStatusDTO().Load(
                new InternalPropertiesUserStatusDTO(output.Code, output.Description).SetInternalData(output.Id),
                default,
                new AuxiliaryPropertiesUserStatusDTO());
        }

        public static OutputUserStatus GetOutput(UserStatusDTO dto)
        {
            return dto == null ? default : new OutputUserStatus(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description)
                .SetInternalData(dto.InternalPropertiesDTO.Id);
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