using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputUpdateUserMenu : BaseInputUpdate<InputUpdateUserMenu>
    {
        public int Position { get; private set; }
        public int SecondPosition { get; private set; }
        public bool Favorite { get; private set; }
        public bool Visible { get; private set; }

        public InputUpdateUserMenu(int position, int secondPosition, bool favorite, bool visible)
        {
            Position = position;
            SecondPosition = secondPosition;
            Favorite = favorite;
            Visible = visible;
        }
    }
}