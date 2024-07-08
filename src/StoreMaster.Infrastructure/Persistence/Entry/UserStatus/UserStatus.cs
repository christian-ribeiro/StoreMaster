using StoreMaster.Domain.DTO;
using StoreMaster.Domain.Extensions;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class UserStatus : BaseEntry<UserStatus>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }

        #region Virtual Properties
        #region External
        public virtual List<User> ListUser { get; private set; }
        #endregion
        #endregion

        public UserStatus() { }

        public UserStatus(string code, string description, List<User> listUser)
        {
            Code = code;
            Description = description;
            ListUser = listUser;
        }

#nullable disable
        public static UserStatusDTO GetDTO(UserStatus userStatus)
        {
            return userStatus == null ? default : new UserStatusDTO().Load(
                    new InternalPropertiesUserStatusDTO(userStatus.Code, userStatus.Description).SetInternalData(userStatus.Id, userStatus.CreationDate, userStatus.ChangeDate),
                    default,
                    new AuxiliaryPropertiesUserStatusDTO(userStatus.ListUser.ConvertAll<UserDTO>())
                );
        }

        public static UserStatus GetEntry(UserStatusDTO dto)
        {
            return dto == null ? default : new UserStatus(dto.InternalPropertiesDTO.Code, dto.InternalPropertiesDTO.Description, dto.AuxiliaryPropertiesDTO.ListUser.ConvertAll<User>())
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate);
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