using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class User : BaseEntry<User>
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public long LanguageId { get; private set; }
        public long UserStatusId { get; private set; }

        #region Virtual Properties
        #region Internal
        public virtual Language? Language { get; private set; }
        public virtual UserStatus? UserStatus { get; private set; }
        #endregion
        #endregion

        public User() { }

        public User(string code, string name, string password, string email, long languageId, long userStatusId, Language? language, UserStatus? userStatus)
        {
            Code = code;
            Name = name;
            Password = password;
            Email = email;
            LanguageId = languageId;
            UserStatusId = userStatusId;
            Language = language;
            UserStatus = userStatus;
        }

#nullable disable
        public static UserDTO GetDTO(User user)
        {
            return user == null ? default : new UserDTO().Load(
                    new InternalPropertiesUserDTO().SetInternalData(user.Id, user.CreationDate, user.ChangeDate),
                    new ExternalPropertiesUserDTO(user.Code, user.Name, user.Password, user.Email, user.LanguageId, user.UserStatusId),
                    new AuxiliaryPropertiesUserDTO(user.Language, user.UserStatus));
        }

        public static User GetEntry(UserDTO dto)
        {
            return dto == null ? default : new User(dto.ExternalPropertiesDTO.Code, dto.ExternalPropertiesDTO.Name, dto.ExternalPropertiesDTO.Password, dto.ExternalPropertiesDTO.Email, dto.ExternalPropertiesDTO.LanguageId, dto.ExternalPropertiesDTO.UserStatusId, dto.AuxiliaryPropertiesDTO.Language, dto.AuxiliaryPropertiesDTO.UserStatus)
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
        }

        public static implicit operator UserDTO(User user)
        {
            return GetDTO(user);
        }

        public static implicit operator User(UserDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}