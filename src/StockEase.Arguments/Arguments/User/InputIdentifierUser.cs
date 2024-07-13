using StockEase.Arguments.Arguments.Base;

namespace StockEase.Arguments.Arguments
{
    public class InputIdentifierUser : BaseInputIdentifier<InputIdentifierUser>
    {
        public string Email { get; private set; }

        public InputIdentifierUser() { }

        public InputIdentifierUser(string email)
        {
            Email = email;
        }
    }
}