using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class AuxiliaryPropertiesUserDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesUserDTO>
    {
        public LanguageDTO? Language { get; private set; }
        public UserStatusDTO? UserStatus { get; private set; }

        public AuxiliaryPropertiesUserDTO() { }

        public AuxiliaryPropertiesUserDTO(LanguageDTO? language, UserStatusDTO? userStatus)
        {
            Language = language;
            UserStatus = userStatus;
        }
    }
}