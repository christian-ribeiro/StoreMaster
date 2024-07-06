using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class User : BaseEntry<User>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string OAuthProvider { get; set; }
        public string OAuthUserId { get; set; }

        public User() { }

        public User(string name, string email, string oAuthProvider, string oAuthUserId)
        {
            Name = name;
            Email = email;
            OAuthProvider = oAuthProvider;
            OAuthUserId = oAuthUserId;
        }

#nullable disable
        public static UserDTO GetDTO(User user)
        {
            return user == null ? default : new UserDTO().Load(
                    new InternalPropertiesUserDTO(user.OAuthProvider, user.OAuthUserId).SetInternalData(user.Id, user.CreationDate, user.ChangeDate),
                    new ExternalPropertiesUserDTO(user.Email, user.Name),
                    new AuxiliaryPropertiesUserDTO()
                );
        }

        public static User GetEntry(UserDTO dto)
        {
            return dto == null ? default : new User(dto.ExternalPropertiesDTO.Email, dto.ExternalPropertiesDTO.Name, dto.InternalPropertiesDTO.OAuthProvider, dto.InternalPropertiesDTO.OAuthUserId)
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