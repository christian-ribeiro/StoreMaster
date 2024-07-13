using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class OutputUserMenu : BaseOutput<OutputUserMenu>
    {
        public int Position { get; private set; }
        public int SecondPosition { get; private set; }
        public bool Favorite { get; private set; }
        public bool Visible { get; private set; }
        public long MenuId { get; private set; }

        #region Virtual Properties
        #region Internal
        public virtual OutputMenu? Menu { get; private set; }
        #endregion
        #endregion

        public OutputUserMenu() { }

        public OutputUserMenu(int position, int secondPosition, bool favorite, bool visible, long menuId, OutputMenu? menu)
        {
            Position = position;
            SecondPosition = secondPosition;
            Favorite = favorite;
            Visible = visible;
            MenuId = menuId;
            Menu = menu;
        }
    }
}