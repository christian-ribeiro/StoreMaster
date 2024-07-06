using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class InternalPropertiesUserDTO : BaseInternalPropertiesDTO<InternalPropertiesUserDTO>
    {
        public string OAuthProvider { get; private set; }
        public string OAuthUserId { get; private set; }

        public InternalPropertiesUserDTO() { }

        public InternalPropertiesUserDTO(string oAuthProvider, string oAuthUserId)
        {
            OAuthProvider = oAuthProvider;
            OAuthUserId = oAuthUserId;
        }
    }
}