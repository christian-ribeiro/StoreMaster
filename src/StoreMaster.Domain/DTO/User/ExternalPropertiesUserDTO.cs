using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class ExternalPropertiesUserDTO : BaseExternalPropertiesDTO<ExternalPropertiesUserDTO>
    {
        public string Email { get; set; }
        public string Name { get; set; }

        public ExternalPropertiesUserDTO() { }

        public ExternalPropertiesUserDTO(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}