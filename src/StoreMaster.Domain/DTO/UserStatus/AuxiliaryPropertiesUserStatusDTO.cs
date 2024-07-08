using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class AuxiliaryPropertiesUserStatusDTO : BaseAuxiliaryPropertiesDTO<AuxiliaryPropertiesUserStatusDTO>
    {
        public List<UserDTO> ListUser { get; private set; }

        public AuxiliaryPropertiesUserStatusDTO() { }

        public AuxiliaryPropertiesUserStatusDTO(List<UserDTO> listUser)
        {
            ListUser = listUser;
        }
    }
}