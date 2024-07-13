using StockEase.Domain.DTO.Base;

namespace StockEase.Domain.DTO
{
    public class ExternalPropertiesUserDTO : BaseExternalPropertiesDTO<ExternalPropertiesUserDTO>
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public long LanguageId { get; private set; }
        public long UserStatusId { get; private set; }

        public ExternalPropertiesUserDTO() { }

        public ExternalPropertiesUserDTO(string code, string name, string password, string email, long languageId, long userStatusId)
        {
            Code = code;
            Name = name;
            Password = password;
            Email = email;
            LanguageId = languageId;
            UserStatusId = userStatusId;
        }
    }
}