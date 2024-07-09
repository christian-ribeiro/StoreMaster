using StoreMaster.Domain.DTO.Base;

namespace StoreMaster.Domain.DTO
{
    public class ExternalPropertiesUserMenuDTO : BaseExternalPropertiesDTO<ExternalPropertiesUserMenuDTO>
    {
        public int Position { get; private set; }
        public int SecondPosition { get; private set; }
        public bool Favorite { get; private set; }
        public bool Visible { get; private set; }
        public long MenuId { get; private set; }

        public ExternalPropertiesUserMenuDTO() { }

        public ExternalPropertiesUserMenuDTO(int position, int secondPosition, bool favorite, bool visible, long menuId)
        {
            Position = position;
            SecondPosition = secondPosition;
            Favorite = favorite;
            Visible = visible;
            MenuId = menuId;
        }
    }
}