using StoreMaster.Domain.DTO;
using StoreMaster.Infrastructure.Persistence.Entry.Base;

namespace StoreMaster.Infrastructure.Persistence.Entry
{
    public class UserMenu : BaseEntry<UserMenu>
    {
        public int Position { get; private set; }
        public int SecondPosition { get; private set; }
        public bool Favorite { get; private set; }
        public bool Visible { get; private set; }
        public long MenuId { get; private set; }

        #region Virtual Properties
        #region Internal
        public virtual Menu? Menu { get; private set; }
        #endregion
        #endregion

        public UserMenu() { }

        public UserMenu(int position, int secondPosition, bool favorite, bool visible, long menuId, Menu? menu)
        {
            Position = position;
            SecondPosition = secondPosition;
            Favorite = favorite;
            Visible = visible;
            MenuId = menuId;
            Menu = menu;
        }

#nullable disable
        public static UserMenuDTO GetDTO(UserMenu userMenu)
        {
            return userMenu == null ? default : new UserMenuDTO().Load(
                    new InternalPropertiesUserMenuDTO().SetInternalData(userMenu.Id, userMenu.CreationDate, userMenu.ChangeDate, userMenu.CreationUserId, userMenu.ChangeUserId),
                    new ExternalPropertiesUserMenuDTO(),
                    new AuxiliaryPropertiesUserMenuDTO().SetInternalData(userMenu.CreationUser, userMenu.ChangeUser));
        }

        public static UserMenu GetEntry(UserMenuDTO dto)
        {
            return dto == null ? default : new UserMenu()
                .SetInternalData(dto.InternalPropertiesDTO.Id, dto.InternalPropertiesDTO.CreationDate, dto.InternalPropertiesDTO.ChangeDate, dto.InternalPropertiesDTO.CreationUserId, dto.InternalPropertiesDTO.ChangeUserId, dto.AuxiliaryPropertiesDTO.CreationUser, dto.AuxiliaryPropertiesDTO.ChangeUser);
        }

        public static implicit operator UserMenuDTO(UserMenu usermenu)
        {
            return GetDTO(usermenu);
        }

        public static implicit operator UserMenu(UserMenuDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}