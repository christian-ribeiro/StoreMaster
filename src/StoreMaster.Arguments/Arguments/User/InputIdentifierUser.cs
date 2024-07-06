using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputIdentifierUser : BaseInputIdentifier<InputIdentifierUser>
    {
        public string Email { get; set; }

        public InputIdentifierUser() { }

        public InputIdentifierUser(string email)
        {
            Email = email;
        }
    }
}