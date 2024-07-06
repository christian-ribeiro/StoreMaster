using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class InputCreateUser : BaseInputCreate<InputCreateUser>
    {
        public string OAuthProvider { get; private set; }
        public string OAuthUserId { get; private set; }
        public string Email { get; private set; }
        public string Name { get; private set; }

        public InputCreateUser(string oAuthProvider, string oAuthUserId, string email, string name)
        {
            OAuthProvider = oAuthProvider;
            OAuthUserId = oAuthUserId;
            Email = email;
            Name = name;
        }
    }
}