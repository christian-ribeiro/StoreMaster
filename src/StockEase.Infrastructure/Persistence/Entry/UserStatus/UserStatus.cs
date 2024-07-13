using StockEase.Domain.DTO;
using StockEase.Infrastructure.Persistence.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockEase.Infrastructure.Persistence.Entry
{
    public class UserStatus : BaseEntry<UserStatus>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        #region NotMapped
        [NotMapped]
        public override DateTime CreationDate => base.CreationDate;
        [NotMapped]
        public override DateTime? ChangeDate => base.ChangeDate;
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
        #region External
        public virtual List<User> ListUser { get; private set; }
        #endregion
        #endregion

        public UserStatus() { }

        public UserStatus(string code, string description)
        {
            Code = code;
            Description = description;
        }

#nullable disable
        public static UserStatusDTO GetDTO(UserStatus userStatus)
        {
            return userStatus == null ? default : new UserStatusDTO().Load(
                    new InternalPropertiesUserStatusDTO(userStatus.Code, userStatus.Description).SetInternalData(userStatus.Id),
                    default,
                    new AuxiliaryPropertiesUserStatusDTO()
                );
        }

        public static UserStatus GetEntry(UserStatusDTO dto)
        {
            return dto == null ? default : new UserStatus(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description)
                .SetInternalData(dto.InternalPropertiesDTO.Id);
        }

        public static implicit operator UserStatusDTO(UserStatus userstatus)
        {
            return GetDTO(userstatus);
        }

        public static implicit operator UserStatus(UserStatusDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}