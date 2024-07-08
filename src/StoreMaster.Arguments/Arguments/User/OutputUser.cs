using StoreMaster.Arguments.Arguments.Base;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputUser : BaseOutput<OutputUser>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public long LanguageId { get; set; }
        public long UserStatusId { get; set; }

        #region VirtualProperties
        #region Internal
        public OutputLanguage Language { get; set; }
        public OutputUserStatus UserStatus { get; set; }
        #endregion
        #endregion

        public OutputUser() { }

        public OutputUser(string code, string name, string password, string email, long languageId, long userStatusId, OutputLanguage language, OutputUserStatus userStatus)
        {
            Code = code;
            Name = name;
            Password = password;
            Email = email;
            LanguageId = languageId;
            UserStatusId = userStatusId;
            Language = language;
            UserStatus = userStatus;
        }
    }
}