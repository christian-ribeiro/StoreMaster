using StockEase.Domain.DTO;
using StockEase.Infrastructure.Persistence.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockEase.Infrastructure.Persistence.Entry
{
    public class Menu : BaseEntry<Menu>
    {
        public string Path { get; private set; }
        public string Label { get; private set; }
        public int Position { get; private set; }
        public bool Visible { get; private set; }
        public string? ToolTip { get; private set; }
        public long? ParentId { get; private set; }

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
        [NotMapped]
        public virtual List<UserMenu> ListUserMenu { get; private set; }
        #endregion
        #endregion

        public Menu() { }

        public Menu(string path, string label, int position, bool visible, string? toolTip, long? parentId)
        {
            Path = path;
            Label = label;
            Position = position;
            Visible = visible;
            ToolTip = toolTip;
            ParentId = parentId;
        }

#nullable disable
        public static MenuDTO GetDTO(Menu menu)
        {
            return menu == null ? default : new MenuDTO().Load(
                    new InternalPropertiesMenuDTO(menu.Path, menu.Label, menu.Position, menu.Visible, menu.ToolTip, menu.ParentId).SetInternalData(menu.Id),
                    default,
                    new AuxiliaryPropertiesMenuDTO());
        }

        public static Menu GetEntry(MenuDTO dto)
        {
            return dto == null ? default : new Menu(dto.InternalPropertiesDTO.Path, dto.InternalPropertiesDTO.Label, dto.InternalPropertiesDTO.Position, dto.InternalPropertiesDTO.Visible, dto.InternalPropertiesDTO.ToolTip, dto.InternalPropertiesDTO.ParentId)
                .SetInternalData(dto.InternalPropertiesDTO.Id);
        }

        public static implicit operator MenuDTO(Menu menu)
        {
            return GetDTO(menu);
        }

        public static implicit operator Menu(MenuDTO dto)
        {
            return GetEntry(dto);
        }
#nullable enable
    }
}