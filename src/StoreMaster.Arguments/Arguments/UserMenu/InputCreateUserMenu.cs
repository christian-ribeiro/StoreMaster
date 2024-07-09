using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputCreateUserMenu : BaseInputCreate<InputCreateUserMenu>
    {
        public int Position { get; private set; }
        public int SecondPosition { get; private set; }
        public bool Favorite { get; private set; }
        public bool Visible { get; private set; }
        public long MenuId { get; private set; }

        public InputCreateUserMenu(int position, int secondPosition, bool favorite, bool visible, long menuId)
        {
            Position = position;
            SecondPosition = secondPosition;
            Favorite = favorite;
            Visible = visible;
            MenuId = menuId;
        }
    }
}