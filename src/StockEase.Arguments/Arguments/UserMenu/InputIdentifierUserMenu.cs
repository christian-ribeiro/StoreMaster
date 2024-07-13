using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentifierUserMenu : BaseInputIdentifier<InputIdentifierUserMenu>
    {
        public long CreationUserId { get; private set; }
        public long MenuId { get; private set; }

        public InputIdentifierUserMenu() { }

        public InputIdentifierUserMenu(long creationUserId, long menuId)
        {
            CreationUserId = creationUserId;
            MenuId = menuId;
        }
    }
}