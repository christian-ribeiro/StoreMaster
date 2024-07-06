using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputUser : BaseOutput<OutputUser>
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string OAuthProvider { get; set; }
        public string OAuthUserId { get; set; }

        #region VirtualProperties
        #region Internal
        #endregion
        #region External
        #endregion
        #endregion

        public OutputUser() { }

        public OutputUser(string email, string name, string oAuthProvider, string oAuthUserId)
        {
            Email = email;
            Name = name;
            OAuthProvider = oAuthProvider;
            OAuthUserId = oAuthUserId;
        }
    }
}