namespace StockEase.Arguments.Arguments
{
    public class OutputCompleteUserMenu
    {
        public long Id { get; set; }
        public int Position { get; set; }
        public int SecondPosition { get; set; }
        public bool Favorite { get; set; }
        public bool Visible { get; set; }
        public long MenuId { get; set; }
        public string Path { get; set; }
        public string Label { get; set; }
        public string? ToolTip { get; set; }
        public List<OutputCompleteUserMenu>? ListUserMenu { get; set; }

        public OutputCompleteUserMenu(long id, int position, int secondPosition, bool favorite, bool visible, long menuId, string path, string label, string? toolTip, List<OutputCompleteUserMenu>? listUserMenu)
        {
            Id = id;
            Position = position;
            SecondPosition = secondPosition;
            Favorite = favorite;
            Visible = visible;
            MenuId = menuId;
            Path = path;
            Label = label;
            ToolTip = toolTip;
            ListUserMenu = listUserMenu;
        }
    }
}