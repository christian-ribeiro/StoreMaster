using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class InternalPropertiesUserDTO : BaseInternalPropertiesDTO<InternalPropertiesUserDTO>
    {
        public string? RefreshToken { get; private set; }

        public InternalPropertiesUserDTO() { }

        public InternalPropertiesUserDTO(string? refreshToken)
        {
            RefreshToken = refreshToken;
        }
    }
}