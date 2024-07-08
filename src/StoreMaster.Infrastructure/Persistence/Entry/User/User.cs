using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class User : BaseEntry<User>
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public string? RefreshToken { get; private set; }
        public long LanguageId { get; private set; }
        public long UserStatusId { get; private set; }

        #region NotMapped
        [NotMapped]
        public override long CreationUserId => base.CreationUserId;
        [NotMapped]
        public override long? ChangeUserId => base.ChangeUserId;
        [NotMapped]
        public override User? CreationUser => base.CreationUser;
        [NotMapped]
        public override User? ChangeUser => base.ChangeUser;
        #endregion

        #region Virtual Properties
        #region Internal
        public virtual Language? Language { get; private set; }
        public virtual UserStatus? UserStatus { get; private set; }
        #endregion
        #region Base External
        #region ProductCategory
        [NotMapped]
        public virtual List<ProductCategory> ListCreationUserProductCategory { get; private set; }
        [NotMapped]
        public virtual List<ProductCategory> ListChangeUserProductCategory { get; private set; }
        #endregion
        #region Product
        [NotMapped]
        public virtual List<Product> ListCreationUserProduct { get; private set; }
        [NotMapped]
        public virtual List<Product> ListChangeUserProduct { get; private set; }
        #endregion
        #region StockConfiguration
        [NotMapped]
        public virtual List<StockConfiguration> ListCreationUserStockConfiguration { get; private set; }
        [NotMapped]
        public virtual List<StockConfiguration> ListChangeUserStockConfiguration { get; private set; }
        #endregion
        #region StockMovement
        [NotMapped]
        public virtual List<StockMovement> ListCreationUserStockMovement { get; private set; }
        #endregion
        #endregion
        #endregion

        public User() { }

        public User(string code, string name, string password, string email, string? refreshToken, long languageId, long userStatusId, Language? language, UserStatus? userStatus)
        {
            Code = code;
            Name = name;
            Password = password;
            Email = email;
            RefreshToken = refreshToken;
            LanguageId = languageId;
            UserStatusId = userStatusId;
            Language = language;
            UserStatus = userStatus;
        }

#nullable disable
        public static UserDTO GetDTO(User user)
        {
            return user == null ? default : new UserDTO().Load(
                    new InternalPropertiesUserDTO(user.RefreshToken).SetInternalData(user.Id, user.CreationDate, user.ChangeDate, user.CreationUserId, user.ChangeUserId),
                    new ExternalPropertiesUserDTO(user.Code, user.Name, user.Password, user.Email, user.LanguageId, user.UserStatusId),
                    new AuxiliaryPropertiesUserDTO(user.Language, user.UserStatus).SetInternalData(user.CreationUser, user.ChangeUser));
        }

        public static User GetEntry(UserDTO dto)
        {
            return dto == null ? default : new User(dto.ExternalPropertiesDTO.Code, dto.ExternalPropertiesDTO.Name, dto.ExternalPropertiesDTO.Password, dto.ExternalPropertiesDTO.Email, dto.InternalPropertiesDTO.RefreshToken, dto.ExternalPropertiesDTO.LanguageId, dto.ExternalPropertiesDTO.UserStatusId, dto.AuxiliaryPropertiesDTO.Language, dto.AuxiliaryPropertiesDTO.UserStatus)
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate, dto.InternalPropertiesDTO.CreationUserId, dto.InternalPropertiesDTO.ChangeUserId, dto.AuxiliaryPropertiesDTO.CreationUser, dto.AuxiliaryPropertiesDTO.ChangeUser);
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