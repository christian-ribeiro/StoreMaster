using StoreMaster.Arguments.Arguments.Base;
using System.Text.Json.Serialization;

namespace StoreMaster.Arguments.Arguments
{
    public class OutputUser : BaseOutput<OutputUser>
    {
        #region Ignore
        [JsonIgnore]
        public override long CreationUserId { get => base.CreationUserId; set => base.CreationUserId = value; }
        [JsonIgnore]
        public override long? ChangeUserId { get => base.ChangeUserId; set => base.ChangeUserId = value; }
        [JsonIgnore]
        public override OutputUser CreationUser { get => base.CreationUser; set => base.CreationUser = value; }
        [JsonIgnore]
        public override OutputUser ChangeUser { get => base.ChangeUser; set => base.ChangeUser = value; }
        #endregion

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