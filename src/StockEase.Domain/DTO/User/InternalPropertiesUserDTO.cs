using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
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