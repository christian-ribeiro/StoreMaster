using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class AuxiliaryPropertiesLanguageDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesLanguageDTO>
    {
        public List<UserDTO> ListUser { get; private set; }

        public AuxiliaryPropertiesLanguageDTO() { }

        public AuxiliaryPropertiesLanguageDTO(List<UserDTO> listUser)
        {
            ListUser = listUser;
        }
    }
}